using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Carts.RemoveProduct
{
    public class RemoveProductCommand : IRequest<Result>
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}
