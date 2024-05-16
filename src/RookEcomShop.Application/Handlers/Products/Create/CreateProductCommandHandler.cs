using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Products.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            IUnitOfWork unitOfWork,
            IUserRepository userRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
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
            List<Task<string>> imgSaveTasks = new();
            if (command.Images != null)
            {
                foreach (var image in command.Images)
                {
                    // Save image to storage and get the path
                    imgSaveTasks.Add(SaveImage(image));
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

            var newProduct = new Product()
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                StockQuantity = command.Stock,
                User = user,
                Category = category,
            };
            newProduct.ProductImages = productImages;
            _productRepository.Create(newProduct);
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task<string> SaveImage(IFormFile image)
        {
            // Generate a unique filename
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);

            // Save the image to a storage location (replace with your storage provider)
            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }
            var filePath = Path.Combine(uploads, fileName);
            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            // Return the relative path to the saved image
            return Path.Combine("/uploads", fileName); // Assuming uploads folder is accessible publicly
        }
    }
}
