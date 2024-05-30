using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.Application.Handlers.Orders.GetList
{
    public class GetListOrderQuery : IRequest<Result<PaginatedList<OrderVM>>>
    {
        public Guid UserId { get; set; }
        public QueryDto QueryObject { get; set; } = new QueryDto();
    }
}