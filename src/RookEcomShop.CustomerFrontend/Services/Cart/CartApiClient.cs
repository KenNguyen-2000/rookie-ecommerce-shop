using Newtonsoft.Json;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.CustomerFrontend.Services.Cart
{
    public class CartApiClient : ICartApiClient
    {
        private readonly HttpClient _httpClient;

        public CartApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7181/api/v1/");
        }

        public async Task<List<CartDetailVM>> GetProductsInCart()
        {
            var response = await _httpClient.GetAsync("carts/products");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var productsInCart = JsonConvert.DeserializeObject<List<CartDetailVM>>(content)!;
            return (dynamic)productsInCart;
        }
    }
}