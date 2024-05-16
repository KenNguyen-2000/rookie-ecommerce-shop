using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Carts.Create;
using RookEcomShop.Domain.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RookEcomShop.Application.Handlers.Carts.AddProduct
{
    public class AddProductToCartCommandHandler : IRequestHandler<AddProductToCartCommand, Result>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISender _sender;

        public AddProductToCartCommandHandler(
            IProductRepository productRepository,
            ICartRepository cartCategory,
            IUnitOfWork unitOfWork,
            ISender sender)
        {
            _productRepository = productRepository;
            _cartRepository = cartCategory;
            _unitOfWork = unitOfWork;
            _sender = sender;
        }

        public async Task<Result> Handle(AddProductToCartCommand command, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(command.ProductId);
            if (product == null)
            {
                throw new NotFoundException($"Product with id {command.ProductId} not found!");
            }

            var userContext = 2; // Assuming userContext is retrieved elsewhere

            var cart = await _cartRepository.GetCartByUserIdAsync(userContext);
            cart = cart ?? await CreateCartIfNotExists(userContext, cancellationToken);

            AddProductToCart(cart, product, command.Quantity);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task<Cart> CreateCartIfNotExists(int userId, CancellationToken cancellationToken)
        {
            await _sender.Send(new CreateCartCommand { UserId = userId }, cancellationToken);
            return (await _cartRepository.GetCartByUserIdAsync(userId))!;
        }

        private static void AddProductToCart(Cart cart, Product product, int quantity)
        {
            var cartDetail = cart.CartDetails.FirstOrDefault(cd => cd.Product.Id == product.Id);
            if (cartDetail != null)
            {
                cartDetail.Quantity += quantity;
            }
            else
            {
                cart.CartDetails.Add(new CartDetail
                {
                    Product = product,
                    Quantity = quantity
                });
            }
        }
    }
}
