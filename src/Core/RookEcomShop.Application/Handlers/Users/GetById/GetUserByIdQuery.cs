using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Users.GetById
{
    public class GetUserByIdQuery : IRequest<Result>
    {
        public int Id { get; set; }

    }
}