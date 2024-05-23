using Newtonsoft.Json;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.CustomerFrontend.Services.Categories
{
    public class CategoriesApiClient : ICategoriesApiClient
    {
        private readonly HttpClient _httpClient;

        public CategoriesApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7181/");
        }
        public async Task<IList<CategoryVM>> GetCategoriesAsync()
        {
            var response = await _httpClient.GetAsync("api/v1/categories");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<IList<CategoryVM>>(content)!;
            return (dynamic)res;
        }

        public async Task<CategoryVM?> GetCategoryByNameAsync(string categoryName)
        {
            var response = await _httpClient.GetAsync("api/v1/categories/" + categoryName);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<CategoryVM>(content)!;
            return (dynamic)res;
        }
    }
}
