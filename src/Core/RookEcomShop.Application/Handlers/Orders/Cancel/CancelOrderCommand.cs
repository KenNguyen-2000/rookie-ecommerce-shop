using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Orders.Cancel
{
    public class CancelOrderCommand : IRequest<Result>
    {
        public int OrderId { get; set; }
    }
}