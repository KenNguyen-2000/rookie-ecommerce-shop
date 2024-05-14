using RookEcomShop.ViewModels.Product;
using Microsoft.AspNetCore.Authentication;
using System.Text.Json;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public class ProductsApiClient : IProductsHttpClient
    {
        private readonly HttpClient _httpClient;

        public ProductsApiClient(HttpClient httpClient, IHttpContextAccessor httpContext)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:5003/");
        }

        public async Task<IEnumerable<ProductVM>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("api/v1/products");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var productList = JsonSerializer.Deserialize<IList<ProductVM>>(content)!;

            return productList;
        }
    }
}
