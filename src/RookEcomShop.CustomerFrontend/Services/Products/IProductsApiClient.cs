using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public interface IProductsHttpClient
    {
        Task<IEnumerable<ProductVM>> GetProductsAsync();
    }
}
