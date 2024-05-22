using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Application.Handlers.Orders.Confirm
{
    public class ConfirmOrderCommandHandler : IRequestHandler<ConfirmOrderCommand, Result>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ConfirmOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(ConfirmOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.OrderId, cancellationToken);

            if (order == null)
                throw new NotFoundException("Order not found");


            if (order.Status != OrderStatus.Pending)
                throw new BadRequestException("Order cannot be cancelled");

            order.Status = OrderStatus.Processing;
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}