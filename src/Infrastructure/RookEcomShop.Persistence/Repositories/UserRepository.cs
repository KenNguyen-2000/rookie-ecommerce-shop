using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.User;
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
    }
}
