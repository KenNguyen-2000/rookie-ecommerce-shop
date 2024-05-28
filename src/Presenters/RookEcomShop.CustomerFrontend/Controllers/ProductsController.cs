using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Authorize]
    [Route("products")]
    public class ProductsController : Controller
    {
        [BindProperty]
        public AddToCartInput AddToCartInput { get; set; } = new AddToCartInput();
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductsApiClient _productsApiClient;
        private readonly ICategoriesApiClient _categoriesApiClient;

        public ProductsController(
            IProductsApiClient productsApiClient,
            ILogger<ProductsController> logger,
            ICategoriesApiClient categoriesApiClient)
        {
            _productsApiClient = productsApiClient;
            _logger = logger;
            _categoriesApiClient = categoriesApiClient;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Get products from API");
            var products = await _productsApiClient.GetProductsAsync();
            return View(products);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            _logger.LogInformation("Get product by id from API");
            var product = await _productsApiClient.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> AddToCart(Guid id)
        {
            _logger.LogInformation("Add product to cart");
            var product = await _productsApiClient.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return Redirect("/cart");
        }

    }
}
