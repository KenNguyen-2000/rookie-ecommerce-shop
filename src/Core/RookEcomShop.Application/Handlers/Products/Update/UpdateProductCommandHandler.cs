using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Application.Services;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommandHandler : BaseService, IRequestHandler<UpdateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IFileStorageService _fileStorageService;

        public UpdateProductCommandHandler(
            IProductRepository productRepository,
            IUnitOfWork unitOfWork,
            IFileStorageService fileStorageService,
            ICategoryRepository categoryRepository) : base(unitOfWork)
        {
            _productRepository = productRepository;
            _fileStorageService = fileStorageService;
            _categoryRepository = categoryRepository;
        }

        public async Task<Result> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository
                                            .GetByIdAsync(command.Id, cancellationToken)
                                            .ThrowIfNullAsync($"Product with id {command.Id}");

            var category = await _categoryRepository
                                    .GetCategoryByNameAsync(command.CategoryName, cancellationToken)
                                    .ThrowIfNullAsync($"Category with name {command.CategoryName}");

            existingProduct.Category = category;
            existingProduct.ProductImages = await UpdateProductImages(command, existingProduct);
            UpdateProduct(existingProduct, command);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task<List<ProductImage>> UpdateProductImages(UpdateProductCommand command, Product existingProduct)
        {
            List<ProductImage> productImages = [.. existingProduct.ProductImages];
            if (command.Images != null && command.Images.Count > 0)
            {
                await RemoveProductImages(existingProduct);
                productImages = await SaveProductImages(command.Images);
            }

            return productImages;
        }

        private async Task RemoveProductImages(Product existingProduct)
        {
            List<Task> imgDeleteTasks = [];
            imgDeleteTasks.AddRange(existingProduct.ProductImages.Select(image => _fileStorageService.DeleteFileAsync(image.Url)));

            await Task.WhenAll(imgDeleteTasks);
            existingProduct.ProductImages.Clear();
        }

        private static void UpdateProduct(Product existingProduct, UpdateProductCommand command)
        {
            existingProduct.Name = command.Name;
            existingProduct.Description = command.Description;
            existingProduct.Price = command.Price;
            existingProduct.Status = command.Status;
            existingProduct.StockQuantity = command.StockQuantity;
        }

        private async Task<List<ProductImage>> SaveProductImages(IFormFileCollection images)
        {
            List<ProductImage> productImages = [];
            List<Task<string>> imgSaveTasks = [];

            imgSaveTasks.AddRange(images.Select(_fileStorageService.SaveFileAsync));

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
