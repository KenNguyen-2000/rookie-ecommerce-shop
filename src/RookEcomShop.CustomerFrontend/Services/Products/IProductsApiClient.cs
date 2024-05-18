using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public interface IProductsApiClient
    {
        Task<List<ProductVM>> GetProductsAsync();
        Task<List<ProductVM>> GetProductsByCategoryNameAsync(string categoryName);
        Task<ProductVM?> GetProductByIdAsync(int id);
    }
}
