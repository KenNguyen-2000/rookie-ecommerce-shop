using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.User;

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
            var users = await _userRepository.GetUsersAsync();

            return Result.Ok(users);
        }
    }
}
