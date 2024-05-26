using Newtonsoft.Json;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.CustomerFrontend.Services.Categories
{
    public class OrdersApiClient : IOrdersApiClient
    {
        private readonly HttpClient _httpClient;

        public OrdersApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<OrderVM>> GetOrdersAsync()
        {
            var response = await _httpClient.GetAsync("orders");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<OrderVM>>(content)!;

            return data;
        }

        public async Task CreateOrderAsync()
        {
            var response = await _httpClient.PostAsync("orders", null);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
    }
}
