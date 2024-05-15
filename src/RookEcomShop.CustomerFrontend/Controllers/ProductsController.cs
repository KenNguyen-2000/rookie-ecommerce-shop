using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Products;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductsApiClient _productsApiClient;

        public ProductsController(IProductsApiClient productsApiClient, ILogger<ProductsController> logger)
        {
            _productsApiClient = productsApiClient;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Get products from API");
            var products = await _productsApiClient.GetProductsAsync();
            ViewData["Products"] = products;
            return View(products.ToList());
        }
    }
}
