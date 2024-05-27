using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {

        public ProductRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public void SoftDelete(Product entity)
        {
            _dbContext.Entry(entity).Property("IsDeleted").CurrentValue = true;
        }

        public override async Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        }

        public override async Task<IEnumerable<Product>> GetListAsync(Expression<Func<Product, bool>>? filter, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .Where(filter ?? (e => true))
                .ToListAsync(cancellationToken);
        }

    }
}
