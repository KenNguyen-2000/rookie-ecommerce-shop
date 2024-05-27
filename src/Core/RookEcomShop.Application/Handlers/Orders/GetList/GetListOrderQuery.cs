using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.Application.Handlers.Orders.GetList
{
    public class GetListOrderQuery : IRequest<Result<IEnumerable<OrderVM>>>
    {
        public int UserId { get; set; }
    }
}