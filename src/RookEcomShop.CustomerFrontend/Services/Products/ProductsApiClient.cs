using RookEcomShop.ViewModels.Product;
using Microsoft.AspNetCore.Authentication;
using System.Text.Json;
using Newtonsoft.Json;

namespace RookEcomShop.CustomerFrontend.Services.Products
{
    public class ProductsApiClient : IProductsApiClient
    {
        private readonly HttpClient _httpClient;

        public ProductsApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7181/");
        }

        public async Task<IList<ProductVM>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("api/v1/products");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var productList = JsonConvert.DeserializeObject<IList<ProductVM>>(content)!;

            return productList;
        }
    }
}
