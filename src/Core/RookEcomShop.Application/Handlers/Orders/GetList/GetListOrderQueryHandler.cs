using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Users;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders.GetList
{
    public class GetListOrderQueryHandler : IRequestHandler<GetListOrderQuery, Result<PaginatedList<OrderDto>>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;

        public GetListOrderQueryHandler(IOrderRepository orderRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }

        public async Task<Result<PaginatedList<OrderDto>>> Handle(GetListOrderQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
            {
                throw new NotFoundException($"User with id {request.UserId} not found!");
            }
            var orders = await _orderRepository.GetListAsync(o => o.UserId == request.UserId, request.QueryObject, cancellationToken);
            var orderVMs = orders.Items.Select(OrdersMapper.MapToOrderDto);

            return Result.Ok(PaginatedList<OrderDto>.Create(
                orderVMs,
                orders.TotalCount,
                orders.Page,
                orders.PageSize));
        }

    }
}