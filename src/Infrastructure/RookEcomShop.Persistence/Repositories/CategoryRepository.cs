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

        public async Task<Category?> GetCategoryByIdAsync(Guid id)
        {
            return await _dbContext.Categories.Include(c => c.SubCategories).FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<Category?> GetCategoryByNameAsync(string name)
        {
            return await _dbContext.Categories.Include(c => c.SubCategories).FirstOrDefaultAsync(e => e.Name.Equals(name));
        }

        public async Task<IEnumerable<Category>> GetListAsync(Expression<Func<Category, bool>>? filter, CancellationToken cancellationToken = default)
        {
            return filter == null
                ? await _dbContext.Categories
                    .Include(c => c.SubCategories)
                    .ToListAsync(cancellationToken)
                : await _dbContext.Categories
                    .Include(c => c.SubCategories)
                    .Where(filter)
                    .ToListAsync(cancellationToken);
        }
    }
}
