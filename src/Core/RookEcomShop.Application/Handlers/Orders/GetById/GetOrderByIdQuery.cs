using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.Application.Handlers.Orders.GetById
{
    public class GetOrderByIdQuery : IRequest<Result<OrderVM>>
    {
        public int OrderId { get; set; }
    }
}