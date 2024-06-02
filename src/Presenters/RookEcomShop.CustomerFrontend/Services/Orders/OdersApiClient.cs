using Newtonsoft.Json;
using RookEcomShop.ViewModels.Contracts.Order;
using RookEcomShop.ViewModels.Dto;
using Serilog;
using System.Text;

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

        public async Task CreateOrderAsync(CreateOrderRequest request)
        {
            var jsonData = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("orders", content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            Log.Information(responseBody);
        }
    }
}
