using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.Application.Handlers.Orders.Create
{
    public class CreateOrderCommand : CreateOrderRequest, IRequest<Result>
    {
        public int UserId { get; set; }
    }
}
