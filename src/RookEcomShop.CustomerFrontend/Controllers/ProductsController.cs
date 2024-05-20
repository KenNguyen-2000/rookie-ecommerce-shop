﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Authorize]
    [Route("products")]
    public class ProductsController : Controller
    {
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
            ViewData["Products"] = products;
            return View(products);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            _logger.LogInformation("Get product by id from API");
            var product = await _productsApiClient.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
