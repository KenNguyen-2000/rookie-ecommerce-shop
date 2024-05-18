﻿using Newtonsoft.Json;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Product;

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

        public async Task<ProductVM> GetProductByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/v1/products/{id}");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<ProductVM>(content)!;
            return product;
        }

        public async Task<IList<ProductVM>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("api/v1/products");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<IList<ProductVM>>(content)!;
            return products;
        }
    }
}
