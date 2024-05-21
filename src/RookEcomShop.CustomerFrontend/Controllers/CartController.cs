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

        [HttpPost("add-to-cart/{productId}")]
        public async Task<IActionResult> AddToCart(int productId)
        {
            var product = await _productsApiClient.GetProductByIdAsync(productId);
            return Redirect("/cart");
        }
    }
}
