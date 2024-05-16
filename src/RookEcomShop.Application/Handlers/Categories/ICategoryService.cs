using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Application.Handlers.Categories
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryVM>> GetCategories(CancellationToken cancellation = default);
        Task CreateCategory(CreateCategoryRequest createCategoryRequest);
    }
}
