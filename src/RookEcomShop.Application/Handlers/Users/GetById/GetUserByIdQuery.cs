using FluentResults;
using MediatR;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Users.GetById
{
    public class GetUserByIdQuery : IRequest<Result<User>>
    {
        public int Id { get; set; }

    }
}