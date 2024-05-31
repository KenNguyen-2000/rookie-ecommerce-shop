using Newtonsoft.Json;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Services.Orders
{
    public class OrdersApiClient : IOrdersApiClient
    {
        private readonly HttpClient _httpClient;

        public OrdersApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<OrderDto>> GetOrdersAsync()
        {
            var response = await _httpClient.GetAsync("orders");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<OrderDto>>(content)!;

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
