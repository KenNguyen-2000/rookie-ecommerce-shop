using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RookEcomShopDbContext context) : base(context)
        {
        }

        public async Task<Category?> GetCategoryByName(string name)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(e => e.Name.Equals(name));
        }

        public override async Task<IEnumerable<Category>> GetListAsync(Expression<Func<Category, bool>>? filter, CancellationToken cancellationToken = default)
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
