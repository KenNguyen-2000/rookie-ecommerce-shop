using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public interface IProductsApiClient
    {
        Task<IList<ProductVM>> GetProductsAsync();
    }
}
