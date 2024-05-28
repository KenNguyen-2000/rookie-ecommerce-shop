using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public interface IProductsApiClient
    {
        Task<PaginatedList<ProductVM>> GetProductsAsync();
        Task<PaginatedList<ProductVM>> GetProductsByCategoryNameAsync(string categoryName, QueryDto queryDto);
        Task<ProductVM?> GetProductByIdAsync(Guid id);
    }
}
