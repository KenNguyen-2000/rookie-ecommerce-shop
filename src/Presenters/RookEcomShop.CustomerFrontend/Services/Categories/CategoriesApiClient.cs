using Newtonsoft.Json;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Services.Categories
{
    public class CategoriesApiClient : ICategoriesApiClient
    {
        private readonly HttpClient _httpClient;

        public CategoriesApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IList<CategoryDto>> GetCategoriesAsync()
        {
            var response = await _httpClient.GetAsync("categories");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<IList<CategoryDto>>(content)!;
            return (dynamic)res;
        }

        public async Task<CategoryDto?> GetCategoryByNameAsync(string categoryName)
        {
            var response = await _httpClient.GetAsync("categories/" + categoryName);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<CategoryDto>(content)!;
            return (dynamic)res;
        }
    }
}
