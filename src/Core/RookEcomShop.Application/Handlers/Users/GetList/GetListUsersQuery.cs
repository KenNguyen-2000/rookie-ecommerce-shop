using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Users.GetList
{
    public class GetListUsersQuery : IRequest<Result<IEnumerable<UserDto>>>
    {
    }
}
