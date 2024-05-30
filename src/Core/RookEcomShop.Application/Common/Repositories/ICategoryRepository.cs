using System.Linq.Expressions;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<Category?> GetCategoryByNameAsync(string name);
        Task<Category?> GetCategoryByIdAsync(Guid id);
        Task<IEnumerable<Category>> GetListAsync(Expression<Func<Category, bool>>? filter = null, CancellationToken cancellationToken = default);
    }
}
