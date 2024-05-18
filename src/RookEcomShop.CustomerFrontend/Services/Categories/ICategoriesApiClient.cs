using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.CustomerFrontend.Services.Categories
{
    public interface ICategoriesApiClient
    {
        Task<IList<CategoryVM>> GetCategoriesAsync();
    }
}
