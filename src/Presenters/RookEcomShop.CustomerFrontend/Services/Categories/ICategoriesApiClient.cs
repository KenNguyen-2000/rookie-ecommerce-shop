using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Services.Categories
{
    public interface ICategoriesApiClient
    {
        Task<IList<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto?> GetCategoryByNameAsync(string categoryName);
    }
}
