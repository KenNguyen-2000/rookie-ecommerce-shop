using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Users.GetList
{
    public class GetListUsersQuery : IRequest<Result<PaginatedList<UserDto>>>
    {
        public QueryDto QueryObject { get; set; } = new QueryDto();
    }
}
