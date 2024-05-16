using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Products.Create
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductHandler(
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

        public async Task Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(command.CategoryId);

            if (category == null)
                throw new NotFoundException("Category not found");

            var user = await _userRepository.GetUserByIdAsync(command.UserId);
            if (user == null)
                throw new NotFoundException("User not found");

            var newProduct = new Product()
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                StockQuantity = command.Stock,
                User = user,
                Category = category
            };
            _productRepository.Create(newProduct);
            await _unitOfWork.SaveAsync();
        }
    }
}
