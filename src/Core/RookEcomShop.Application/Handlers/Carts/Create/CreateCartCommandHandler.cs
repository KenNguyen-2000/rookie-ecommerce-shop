using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Carts.Create
{
    public class CreateCartCommandHandler : BaseService, IRequestHandler<CreateCartCommand, Result>
    {
        private readonly ICartRepository _cartRepository;

        public CreateCartCommandHandler(ICartRepository cartRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _cartRepository = cartRepository;
        }

        public async Task<Result> Handle(CreateCartCommand command, CancellationToken cancellationToken)
        {
            _cartRepository.Create(new Cart
            {
                UserId = command.UserId,

            });
            await _unitOfWork.SaveAsync(cancellationToken);
            return Result.Ok();
        }
    }
}
