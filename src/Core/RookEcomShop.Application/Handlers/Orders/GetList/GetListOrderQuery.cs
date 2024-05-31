using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders.GetList
{
    public class GetListOrderQuery : IRequest<Result<PaginatedList<OrderDto>>>
    {
        public Guid UserId { get; set; }
        public QueryDto QueryObject { get; set; } = new QueryDto();
    }
}