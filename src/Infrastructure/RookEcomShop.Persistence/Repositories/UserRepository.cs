using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public async Task<UserDto?> GetByIdAsync(Guid userId)
        {
            return await _dbContext.Users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
                Address = u.Address,
                Dob = u.Dob,
                Gender = u.Gender,
                AvartarUrl = u.AvartarUrl
            }).FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<PaginatedList<UserDto>> GetListAsync(
            Expression<Func<User, bool>>? filter,
            QueryDto queryDto,
            CancellationToken cancellationToken = default)
        {
            IQueryable<User> query = _dbContext.Users;
            if (filter != null)
            {
                query.Where(filter);
            }

            query = QueryHelper<QueryDto, User>.SortValues(queryDto, query, GetSortProperty(queryDto));
            var totalCount = query.Count();
            query = QueryHelper<QueryDto, User>.PaginateValues(queryDto, query);
            IEnumerable<UserDto> userDtos = await query.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
                Address = u.Address,
                Dob = u.Dob,
                Gender = u.Gender,
                AvartarUrl = u.AvartarUrl
            }).ToListAsync(cancellationToken);
            return PaginatedList<UserDto>.Create(userDtos, queryDto.Page, queryDto.PageSize, totalCount);
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync(Expression<Func<User, bool>>? filter)
        {
            var query = _dbContext.Users;
            if (filter != null)
            {
                query.Where(filter);
            }
            return await query.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
                Address = u.Address,
                Dob = u.Dob,
                Gender = u.Gender,
                AvartarUrl = u.AvartarUrl
            }).ToListAsync();
        }

        public async Task<IEnumerable<UserDto>> GetUsersByIds(IEnumerable<Guid> userIds)
        {
            return await _dbContext.Users.Where(u => userIds.Contains(u.Id)).Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
                Address = u.Address,
                Dob = u.Dob,
            }).ToListAsync();
        }

        private static Expression<Func<User, object>> GetSortProperty(QueryDto queryDto) =>
     queryDto.SortColumn?.ToLower() switch
     {
         "name" => user => $"{user.FirstName} {user.LastName}",
         "email" => user => user.Email ?? string.Empty,
         "phoneNumber" => user => user.PhoneNumber ?? string.Empty,
         _ => user => user.Id
     };
    }
}
