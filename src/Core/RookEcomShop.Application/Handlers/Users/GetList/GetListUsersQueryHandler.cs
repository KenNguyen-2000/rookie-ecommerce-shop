using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Products.GetList;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;
using RookEcomShop.ViewModels.User;
using System.Linq.Expressions;

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
