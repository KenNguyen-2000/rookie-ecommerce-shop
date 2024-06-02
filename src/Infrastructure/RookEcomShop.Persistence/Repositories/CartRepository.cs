using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Persistence.Repositories
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(RookEcomShopDbContext context) : base(context)
        {
        }


        public async Task<Cart?> GetCartByUserIdAsync(Guid userId, CancellationToken cancellationToken = default!)
        {
            return await _dbContext.Carts
                    .Include(e => e.CartDetails)
                        .ThenInclude(cd => cd.Product)
                            .ThenInclude(p => p.ProductImages)
                    .Include(e => e.CartDetails)
                        .ThenInclude(cd => cd.Product)
                            .ThenInclude(p => p.Category)
                    .FirstOrDefaultAsync(e => e.UserId.Equals(userId), cancellationToken);
        }
    }
}
