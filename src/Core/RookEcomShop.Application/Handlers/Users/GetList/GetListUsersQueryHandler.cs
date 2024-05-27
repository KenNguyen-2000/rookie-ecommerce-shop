using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Users.GetList
{
    public class GetListUsersQueryHandler : IRequestHandler<GetListUsersQuery, Result<IEnumerable<UserDto>>>
    {
        private readonly IUserRepository _userRepository;

        public GetListUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<Result<IEnumerable<UserDto>>> Handle(GetListUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetUsers();

            return Result.Ok(users);
        }
    }
}
