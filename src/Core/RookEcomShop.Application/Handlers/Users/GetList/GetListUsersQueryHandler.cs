using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Users.GetList
{
    public class GetListUsersQueryHandler : IRequestHandler<GetListUsersQuery, Result<PaginatedList<UserDto>>>
    {
        private readonly IUserRepository _userRepository;

        public GetListUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<Result<PaginatedList<UserDto>>> Handle(GetListUsersQuery query, CancellationToken cancellationToken)
        {
            PaginatedList<UserDto> paginatedUsers = await _userRepository.GetListAsync(queryDto: query.QueryObject,
                                                                                       cancellationToken: cancellationToken);


            return Result.Ok(paginatedUsers);
        }
    }
}
