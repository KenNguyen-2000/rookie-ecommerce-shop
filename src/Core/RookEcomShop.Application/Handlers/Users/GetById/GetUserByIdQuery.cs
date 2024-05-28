using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.User;

namespace RookEcomShop.Application.Handlers.Users.GetById
{
    public class GetUserByIdQuery : IRequest<Result<UserDto>>
    {
        public int Id { get; set; }

    }
}