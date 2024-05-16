using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.Handlers.Carts.RemoveProduct
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand, Result>
    {
        private readonly ICartRepository _cartRepository;
        private readonly ISender _sender;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveProductCommandHandler(ICartRepository cartRepository, ISender sender, IUnitOfWork unitOfWork)
        {
            _cartRepository = cartRepository;
            _sender = sender;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(RemoveProductCommand command, CancellationToken cancellationToken)
        {
            var cart = await _cartRepository.GetCartByUserIdAsync(command.UserId);

            if (cart is null)
                throw new NotFoundException($"User does not have any products in cart!");

            var product = cart!.CartDetails.FirstOrDefault(cD => cD.Product.Id == command.ProductId);

            if (product is null)
                throw new NotFoundException($"Product with id {command.ProductId} not found in cart!");

            cart.CartDetails.Remove(product);
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
