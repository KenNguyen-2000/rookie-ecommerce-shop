using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Orders.Confirm
{
    public class ConfirmOrderCommand : IRequest<Result>
    {
        public Guid OrderId { get; set; }
    }
}