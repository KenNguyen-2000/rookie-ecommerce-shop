using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Persistence.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders.GetById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Result<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Result<OrderDto>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository
                                .GetByIdAsync(request.OrderId, cancellationToken)
                                .ThrowIfNullAsync($"Order with id {request.OrderId}");

            return Result.Ok(OrdersMapper.MapToOrderDto(order));
        }
    }
}