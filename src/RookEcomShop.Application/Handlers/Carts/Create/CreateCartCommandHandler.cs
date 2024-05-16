using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Carts.Create
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, Result>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCartCommandHandler(ICartRepository cartRepository, IUnitOfWork unitOfWork)
        {
            _cartRepository = cartRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(CreateCartCommand command, CancellationToken cancellationToken)
        {
            var userIdFromContext = 1;
            _cartRepository.Create(new Cart
            {
                UserId = userIdFromContext
            });
            await _unitOfWork.SaveAsync(cancellationToken);
            return Result.Ok();
        }
    }
}
