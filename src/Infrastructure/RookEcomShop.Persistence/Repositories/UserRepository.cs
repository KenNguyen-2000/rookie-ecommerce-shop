using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.User;

namespace RookEcomShop.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly RookEcomShopDbContext _dbContext;

        public UserRepository(RookEcomShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
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
            }).ToListAsync();
        }
    }
}
