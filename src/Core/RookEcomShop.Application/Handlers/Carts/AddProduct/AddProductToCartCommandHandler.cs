using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Carts.Create;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Carts.AddProduct
{
    public class AddProductToCartCommandHandler : IRequestHandler<AddProductToCartCommand, Result>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly UserContext userContext;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISender _sender;

        public AddProductToCartCommandHandler(
            IProductRepository productRepository,
            ICartRepository cartCategory,
            IUnitOfWork unitOfWork,
            ISender sender,
            UserContext userContext)
        {
            _productRepository = productRepository;
            _cartRepository = cartCategory;
            _unitOfWork = unitOfWork;
            _sender = sender;
            this.userContext = userContext;
        }

        public async Task<Result> Handle(AddProductToCartCommand command, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(command.ProductId);
            if (product == null)
            {
                throw new NotFoundException($"Product with id {command.ProductId} not found!");
            }


            var cart = await _cartRepository.GetCartByUserIdAsync(userContext.UserId);
            if (cart is null)
                cart = await CreateCartIfNotExists(userContext.UserId, cancellationToken);

            AddProductToCart(cart, product, command.Quantity);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task<Cart> CreateCartIfNotExists(Guid userId, CancellationToken cancellationToken)
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
