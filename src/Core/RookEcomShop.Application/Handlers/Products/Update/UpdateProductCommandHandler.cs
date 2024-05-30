using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Services;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileStorageService _fileStorageService;

        public UpdateProductCommandHandler(
            IProductRepository productRepository,
            IUnitOfWork unitOfWork,
            IFileStorageService fileStorageService,
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _fileStorageService = fileStorageService;
            _categoryRepository = categoryRepository;
        }

        public async Task<Result> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository.GetByIdAsync(command.Id);

            if (existingProduct == null)
                throw new NotFoundException($"Product with id {command.Id} not found!");
            var category = await _categoryRepository.GetCategoryByNameAsync(command.CategoryName);
            if (category == null)
                throw new NotFoundException($"Category with name {command.CategoryName} not found!");

            existingProduct.Category = category;

            List<ProductImage> productImages = new List<ProductImage>();
            if (command.Images != null)
            {
                await RemoveProductImages(existingProduct);
                if (command.Images.Count > 0)
                {

                    productImages = await SaveProductImages(command);
                }
                else
                    productImages = existingProduct.ProductImages.ToList();
            }

            UpdateProduct(existingProduct, command, productImages);


            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task RemoveProductImages(Product existingProduct)
        {
            List<Task> imgDeleteTasks = new();
            foreach (var image in existingProduct.ProductImages)
            {
                imgDeleteTasks.Add(_fileStorageService.DeleteFileAsync(image.Url));
            }

            await Task.WhenAll(imgDeleteTasks);
            existingProduct.ProductImages.Clear();
        }

        private static void UpdateProduct(Product existingProduct, UpdateProductCommand command, List<ProductImage> productImages)
        {
            existingProduct.Name = command.Name;
            existingProduct.Description = command.Description;
            existingProduct.Price = command.Price;
            existingProduct.Status = command.Status;
            existingProduct.StockQuantity = command.StockQuantity;
            existingProduct.ProductImages = productImages;
        }

        private async Task<List<ProductImage>> SaveProductImages(UpdateProductCommand command)
        {
            List<ProductImage> productImages = new List<ProductImage>();
            List<Task<string>> imgSaveTasks = new();
            if (command.Images != null)
            {
                foreach (var image in command.Images)
                {
                    // Save image to storage and get the path
                    imgSaveTasks.Add(_fileStorageService.SaveFileAsync(image));
                }
            }

            await Task.WhenAll(imgSaveTasks);

            imgSaveTasks.ForEach(task =>
            {
                var productImage = new ProductImage()
                {
                    Url = task.Result
                };
                productImages.Add(productImage);
            });
            return productImages;
        }
    }
}
