using System.Text;
using FluentResults;
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

        public async Task AddProductToCart(AddProductToCartRequest request)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync($"carts/products/add", content);

                response.EnsureSuccessStatusCode();
                // Read the response content
                string responseBody = await response.Content.ReadAsStringAsync();

                // Output the response
                Console.WriteLine(responseBody);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<CartDetailVM>> GetProductsInCart()
        {
            try
            {
                var response = await _httpClient.GetAsync("carts/products");

                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                var productsInCart = JsonConvert.DeserializeObject<IEnumerable<CartDetailVM>>(content)!;
                return (dynamic)productsInCart;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task RemoveProductFromCart(int productId)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"carts/products/{productId}");

                response.EnsureSuccessStatusCode();

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}