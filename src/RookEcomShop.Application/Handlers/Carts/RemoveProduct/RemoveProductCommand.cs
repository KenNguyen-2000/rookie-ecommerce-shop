using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Carts.RemoveProduct
{
    public class RemoveProductCommand : IRequest<Result>
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}
