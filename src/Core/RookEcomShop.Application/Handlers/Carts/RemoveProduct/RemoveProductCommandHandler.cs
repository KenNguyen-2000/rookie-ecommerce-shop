using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Carts.RemoveProduct
{
    public class RemoveProductCommandHandler : BaseService, IRequestHandler<RemoveProductCommand, Result>
    {
        private readonly ICartRepository _cartRepository;

        public RemoveProductCommandHandler(ICartRepository cartRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _cartRepository = cartRepository;
        }

        public async Task<Result> Handle(RemoveProductCommand command, CancellationToken cancellationToken)
        {
            var cart = await _cartRepository
                                .GetCartByUserIdAsync(command.UserId)
                                .ThrowIfNullAsync($"User's cart");

            var product = cart.CartDetails
                                .FirstOrDefault(cD => cD.Product.Id == command.ProductId)
                                .ThrowIfNull($"Product with id {command.ProductId}");

            cart.CartDetails.Remove(product);
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
