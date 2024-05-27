

using Microsoft.EntityFrameworkCore;
using RookEcomShop.Infrastructure.IdentityServer;

namespace RookEcomShop.IdentityServer.Persistence.Repositories
{
    public class UsersRepository
    {
        private readonly IdentityServerDbContext _dbContext;

        public UsersRepository(IdentityServerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ApplicationUser>> GetListUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
