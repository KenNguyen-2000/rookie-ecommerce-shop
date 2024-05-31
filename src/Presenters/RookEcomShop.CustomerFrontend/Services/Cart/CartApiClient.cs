using Newtonsoft.Json;
using RookEcomShop.ViewModels.Contracts.Cart;
using RookEcomShop.ViewModels.Dto;
using Serilog;
using System.Text;

namespace RookEcomShop.CustomerFrontend.Services.Cart
{
    public class CartApiClient : ICartApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CartApiClient> _logger;

        public CartApiClient(HttpClient httpClient, ILogger<CartApiClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task AddProductToCart(AddProductToCartRequest request)
        {
            _logger.LogInformation("Adding product to cart");
            var jsonData = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"carts/products/add", content);

            response.EnsureSuccessStatusCode();
            // Read the response content
            string responseBody = await response.Content.ReadAsStringAsync();

        }

        public async Task<IEnumerable<CartDetailDto>> GetProductsInCart()
        {
            Log.Information("Getting products in cart");
            var response = await _httpClient.GetAsync("carts/products");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var productsInCart = JsonConvert.DeserializeObject<IEnumerable<CartDetailDto>>(content)!;

            _logger.LogInformation("Products in cart: {productsInCart}", productsInCart);
            return (dynamic)productsInCart;
        }

        public async Task RemoveProductFromCart(Guid productId)
        {
            var response = await _httpClient.DeleteAsync($"carts/products/{productId}");

            response.EnsureSuccessStatusCode();
        }
    }
}