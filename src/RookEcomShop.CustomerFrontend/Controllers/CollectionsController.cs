using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Dto;
using RookEcomShop.CustomerFrontend.Models;
using RookEcomShop.CustomerFrontend.Models.Home;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.ViewModels.Product;
using System.Diagnostics;

namespace RookEcomShop.CustomerFrontend.Controllers;

[Route("collections")]
public class CollectionsController : Controller
{
    private readonly ILogger<CollectionsController> _logger;
    private readonly IProductsApiClient _productsApiClient;
    private readonly ICategoriesApiClient _categoriesApiClient;

    public CollectionsController(
        ILogger<CollectionsController> logger,
        IProductsApiClient productsApiClient,
        ICategoriesApiClient categoriesApiClient)
    {
        _logger = logger;
        _productsApiClient = productsApiClient;
        _categoriesApiClient = categoriesApiClient;
    }

    [HttpGet("{categoryName}")]
    public async Task<IActionResult> Details(string categoryName, [FromQuery] QueryDto queryDto)
    {
        PaginatedList<ProductVM> products = await _productsApiClient.GetProductsByCategoryNameAsync(categoryName, queryDto);

        return View(products);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
