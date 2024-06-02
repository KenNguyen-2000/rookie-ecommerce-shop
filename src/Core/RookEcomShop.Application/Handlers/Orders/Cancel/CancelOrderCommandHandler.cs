using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Orders.Cancel
{
    public class CancelOrderCommandHandler : BaseService, IRequestHandler<CancelOrderCommand, Result>
    {
        private readonly IOrderRepository _orderRepository;
        public CancelOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork, UserContext userContext) : base(unitOfWork, userContext)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Result> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository
                                .GetByIdAsync(request.OrderId, cancellationToken)
                                .ThrowIfNullAsync($"Order with id {request.OrderId}");


            if (order.Status != OrderStatus.Pending && _userContext.UserRole == "Buyer")
                throw new BadRequestException("Order cannot be cancelled");

            order.Status = OrderStatus.Cancelled;
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}