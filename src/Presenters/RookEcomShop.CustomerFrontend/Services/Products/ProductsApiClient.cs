using Newtonsoft.Json;
using RookEcomShop.Application.Dto;
using RookEcomShop.CustomerFrontend.Services.Helpers;
using RookEcomShop.ViewModels.Dto;
using Serilog;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public class ProductsApiClient : IProductsApiClient
    {
        private readonly HttpClient _httpClient;

        public ProductsApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductDto?> GetProductByIdAsync(Guid id)
        {
            Log.Information("Call api get product by id {id}", id);
            var response = await _httpClient.GetAsync($"products/{id}");


            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<ProductDto?>(content);
            Log.Information("Get product by id {id} success", id);

            return product;
        }

        public async Task<PaginatedList<ProductDto>> GetProductsAsync(ProductQueryDto queryDto)
        {
            Log.Information("Call api get lists products ");
            var response = await _httpClient.GetAsync($"products?{QueryHelper.ToQueryString<ProductQueryDto>(queryDto)}");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<PaginatedList<ProductDto>>(content)!;
            Log.Information("Get lists products success");

            return products;
        }

        public async Task<PaginatedList<ProductDto>> GetProductsByCategoryNameAsync(string categoryName, QueryDto queryDto)
        {
            Log.Information("Call api get lists products by category name {categoryName}", categoryName);
            var response = await _httpClient.GetAsync($"products/collections/{categoryName}?{QueryHelper.ToQueryString<QueryDto>(queryDto)}");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<PaginatedList<ProductDto>>(content)!;
            Log.Information("Get lists products by category name {categoryName} success", categoryName);

            return products;
        }

    }
}
