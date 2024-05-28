using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.User;

namespace RookEcomShop.Application.Handlers.Users.GetList
{
    public class GetListUsersQuery : IRequest<Result<IEnumerable<UserDto>>>
    {
    }
}
