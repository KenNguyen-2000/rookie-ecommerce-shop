using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Application.Services;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Products.Create
{
    public class CreateProductCommandHandler : BaseService, IRequestHandler<CreateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IFileStorageService _fileStorageService;

        public CreateProductCommandHandler(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            IUnitOfWork unitOfWork,
            IFileStorageService fileStorageService) : base(unitOfWork)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _fileStorageService = fileStorageService;
        }

        public async Task<Result> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository
                                    .GetCategoryByNameAsync(command.CategoryName, cancellationToken)
                                    .ThrowIfNullAsync($"Category with name {command.CategoryName}");

            List<ProductImage> productImages = [];
            if (command.Images is { Count: > 0 })
            {

                productImages = await SaveProductImages(command.Images);
            }

            CreateNewProduct(command, category, productImages);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private void CreateNewProduct(CreateProductCommand command, Category category, List<ProductImage> productImages)
        {
            var newProduct = new Product()
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                StockQuantity = command.StockQuantity,
                UserId = command.UserId,
                Category = category,
                ProductImages = productImages,
                Status = command.Status
            };
            _productRepository.Create(newProduct);
        }

        private async Task<List<ProductImage>> SaveProductImages(IFormFileCollection images)
        {
            List<ProductImage> productImages = [];
            List<Task<string>> imgSaveTasks = [];

            imgSaveTasks.AddRange(images.Select(image => _fileStorageService.SaveFileAsync(image)));


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
