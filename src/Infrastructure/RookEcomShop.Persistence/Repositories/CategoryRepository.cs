using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public async Task<Category?> GetCategoryByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Categories.Include(c => c.SubCategories).FirstOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public async Task<Category?> GetCategoryByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Categories.Include(c => c.SubCategories).FirstOrDefaultAsync(e => e.Name.Equals(name), cancellationToken);
        }

        public async Task<IEnumerable<Category>> GetListAsync(Expression<Func<Category, bool>>? filter, CancellationToken cancellationToken = default)
        {
            var query = _dbContext.Categories.Include(c => c.SubCategories).AsQueryable();
            if (filter != null)
            {
                query.Where(filter);
            }
            return await query
                .ToListAsync(cancellationToken);
        }
    }
}
