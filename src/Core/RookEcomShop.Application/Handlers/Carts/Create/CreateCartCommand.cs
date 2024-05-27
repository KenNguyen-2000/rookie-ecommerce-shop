using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Carts.Create
{
    public class CreateCartCommand : IRequest<Result>
    {
        public int UserId { get; set; }
    }
}
