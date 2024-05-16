using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<Category?> GetCategoryByName(string name);
    }
}
