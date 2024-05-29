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
        private readonly IRookEcomShopDbContext _context;

        public GetListUsersQueryHandler( IRookEcomShopDbContext context)
        {
            _context = context;
        }


        public async Task<Result<PaginatedList<UserDto>>> Handle(GetListUsersQuery query, CancellationToken cancellationToken)
        {
            IQueryable<User> usersQuery = _context.Users;

            if (!string.IsNullOrWhiteSpace(query.QueryObject.SearchTerm))
            {
                usersQuery = usersQuery.Where(user =>
                    user.FirstName.Contains(query.QueryObject.SearchTerm) ||
                    user.LastName.Contains(query.QueryObject.SearchTerm) ||
                    (user.Email == null || user.Email.Contains(query.QueryObject.SearchTerm)));
            }

            if (query.QueryObject.SortOrder?.ToLower() == "desc")
            {
                usersQuery = usersQuery.OrderByDescending(GetSortProperty(query));
            }
            else
            {
                usersQuery = usersQuery.OrderBy(GetSortProperty(query));
            }

            var userResponsesQuery = usersQuery.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Address = u.Address,
                PhoneNumber = u.PhoneNumber,
                Dob = u.Dob,
                Gender = u.Gender,
                AvartarUrl = u.AvartarUrl,
            });

            var users = await PaginatedList<UserDto>.CreateAsync(userResponsesQuery, query.QueryObject.Page, query.QueryObject.PageSize);

            return Result.Ok(users);
        }

        private static Expression<Func<User, object>> GetSortProperty(GetListUsersQuery request) =>
     request.QueryObject.SortColumn?.ToLower() switch
     {
         "name" => user => $"{user.FirstName} {user.LastName}",
         "email" => user => user.Email,
         "phoneNumber" => user => user.PhoneNumber,
         _ => user => user.Id
     };
    }
}
