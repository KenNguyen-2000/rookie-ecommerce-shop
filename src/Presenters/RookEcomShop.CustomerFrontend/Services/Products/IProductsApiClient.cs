using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public interface IProductsApiClient
    {
        Task<PaginatedList<ProductDto>> GetProductsAsync(ProductQueryDto queryDto = default!);
        Task<PaginatedList<ProductDto>> GetProductsByCategoryNameAsync(string categoryName, QueryDto queryDto);
        Task<ProductDto?> GetProductByIdAsync(Guid id);
        Task<IEnumerable<ProductDto>> GetBestSellersAsync(int count);
        Task<IEnumerable<ProductDto>> GetBestReviewsAsync(int count);
    }
}
