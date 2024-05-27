
using Newtonsoft.Json;

namespace RookEcomShop.CustomerFrontend.Services.Accounts
{
    public class AccountApiClient : IAccountApiClient
    {
        private readonly HttpClient _httpClient;

        public AccountApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7280");
        }

        public async Task<dynamic> GetUser()
        {
            var response = await _httpClient.GetAsync("/api/v1/users");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<dynamic>(content);

            return data;
        }
    }
}
