using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Products;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Authorize]
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private readonly IProductsApiClient _productsApiClient;

        public CartController(IProductsApiClient productsApiClient, ILogger<CartController> logger)
        {
            _logger = logger;
            _productsApiClient = productsApiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("add-to-cart/{productId}")]
        public async Task<IActionResult> AddToCart(int productId)
        {
            var product = await _productsApiClient.GetProductByIdAsync(productId);
            return Redirect("/cart");
        }
    }
}
