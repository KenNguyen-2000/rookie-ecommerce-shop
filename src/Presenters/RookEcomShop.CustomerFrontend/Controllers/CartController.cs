using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Cart;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.ViewModels.Contracts.Cart;
using RookEcomShop.ViewModels.Dto;

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
            IEnumerable<CartDetailDto> productsInCart = await _cartApiClient.GetProductsInCart();
            return View(productsInCart);
        }

        [HttpPost("{productId}")]
        public async Task<IActionResult> AddToCart(AddProductToCartRequest request)
        {
            _logger.LogInformation("Adding product to cart: " + request);
            await _cartApiClient.AddProductToCart(request);

            return Ok();
        }

        [HttpPost("{productId}/remove")]
        public async Task<IActionResult> RemoveFromCart(Guid productId)
        {
            try
            {
                _logger.LogInformation($"Remove product with id {productId} from cart");
                await _cartApiClient.RemoveProductFromCart(productId);
                Console.WriteLine("Removing product from cart: " + productId);
            }
            catch (System.Exception e)
            {

                Console.WriteLine(e);
            }
            return Redirect("/cart");
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
