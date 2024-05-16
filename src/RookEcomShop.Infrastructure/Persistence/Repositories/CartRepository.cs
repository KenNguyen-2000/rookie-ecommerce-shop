using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Repositories
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(RookEcomShopDbContext context) : base(context)
        {
        }


        public async Task<Cart?> GetCartByUserIdAsync(int userId)
        {
            return await _dbContext.Carts.FirstOrDefaultAsync(e => e.UserId.Equals(userId));
        }
    }
}
