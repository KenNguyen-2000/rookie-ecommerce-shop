using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders.GetList
{
    public class GetListOrderQueryHandler : BaseService, IRequestHandler<GetListOrderQuery, Result<PaginatedList<OrderDto>>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;

        public GetListOrderQueryHandler(IOrderRepository orderRepository, IUserRepository userRepository, UserContext userContext) : base(userContext)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }

        public async Task<Result<PaginatedList<OrderDto>>> Handle(GetListOrderQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetListAsync(null, request.QueryObject, cancellationToken);
            var orderVMs = orders.Items.Select(OrdersMapper.MapToOrderDto);

            return Result.Ok(PaginatedList<OrderDto>.Create(
                orderVMs,
                orders.TotalCount,
                orders.Page,
                orders.PageSize));
        }

    }
}