using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Services;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Products.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileStorageService _fileStorageService;

        public CreateProductCommandHandler(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            IUnitOfWork unitOfWork,
            IUserRepository userRepository,
            IFileStorageService fileStorageService)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _fileStorageService = fileStorageService;
        }

        public async Task<Result> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(command.CategoryId);

            if (category == null)
                throw new NotFoundException("Category not found");

            var user = await _userRepository.GetUserByIdAsync(command.UserId);
            if (user == null)
                throw new NotFoundException("User not found");

            List<ProductImage> productImages = new List<ProductImage>();
            if (command.Images != null && command.Images.Count > 0)
            {

                productImages = await SaveProductImages(command);
            }

            var newProduct = new Product()
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                StockQuantity = command.Stock,
                User = user,
                Category = category,
                ProductImages = productImages
            };
            _productRepository.Create(newProduct);
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task<List<ProductImage>> SaveProductImages(CreateProductCommand command)
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
