using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Cart;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Authorize]
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private readonly IProductsApiClient _productsApiClient;
        private readonly ICartApiClient _cartApiClient;

        public CartController(
            IProductsApiClient productsApiClient,
            ILogger<CartController> logger,
            ICartApiClient cartApiClient)
        {
            _logger = logger;
            _productsApiClient = productsApiClient;
            _cartApiClient = cartApiClient;
        }


        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Cart";
            IEnumerable<CartDetailVM> productsInCart = await _cartApiClient.GetProductsInCart();
            return View(productsInCart);
        }

        [HttpPost("{productId}")]
        public async Task<IActionResult> AddToCart(int productId)
        {
            Console.WriteLine(productId);
            await _cartApiClient.AddProductToCart(productId);

            return Ok();
        }

        [HttpGet("update-header")]
        public async Task<IActionResult> UpdateHeader()
        {
            _logger.LogInformation("Getting products in cart");
            var productsInCart = await _cartApiClient.GetProductsInCart();
            _logger.LogInformation("Updating header");
            ViewData["CartCount"] = productsInCart.Count();
            return ViewComponent("Header", productsInCart);
        }
    }
}
