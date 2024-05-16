using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Carts.Create;
using RookEcomShop.Domain.Entities;

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
                throw new NotFoundException($"Product with id {command.ProductId} not found!");

            var userContext = 1;

            var cart = await _cartRepository.GetCartByUserIdAsync(userContext);
            if (cart is null)
                await _sender.Send(new CreateCartCommand { UserId = userContext });

            cart.CartDetails.Add(new CartDetail
            {
                Product = product,
                Quantity = command.Quantity
            });

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
