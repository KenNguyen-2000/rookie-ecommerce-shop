﻿using System.Web;
using Newtonsoft.Json;
using RookEcomShop.Application.Dto;
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
        }

        public async Task<ProductVM?> GetProductByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"products/{id}");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<ProductVM?>(content);
            return product;
        }

        public async Task<PaginatedList<ProductVM>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("products");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<PaginatedList<ProductVM>>(content)!;
            return products;
        }

        public async Task<PaginatedList<ProductVM>> GetProductsByCategoryNameAsync(string categoryName, QueryDto queryDto)
        {
            var response = await _httpClient.GetAsync($"products/collections/{categoryName}?{ToQueryString(queryDto)}");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<PaginatedList<ProductVM>>(content)!;
            return products;
        }

        public static string ToQueryString(QueryDto queryDto)
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            foreach (var property in queryDto.GetType().GetProperties())
            {
                var value = property.GetValue(queryDto)?.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    queryString[property.Name] = value;
                }
            }
            return queryString.ToString();
        }
    }
}
