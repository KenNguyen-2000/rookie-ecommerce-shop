using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.Application.Handlers.Orders.GetById
{
    public class GetListOrderQuery : IRequest<Result<IEnumerable<OrderVM>>>
    {
        public int UserId { get; set; }
    }
}