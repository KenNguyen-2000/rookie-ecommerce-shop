using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Models;
using RookEcomShop.CustomerFrontend.Models.Home;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;
using System.Diagnostics;

namespace RookEcomShop.CustomerFrontend.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductsApiClient _productsApiClient;
    private readonly ICategoriesApiClient _categoriesApiClient;

    public HomeController(
        ILogger<HomeController> logger,
        IProductsApiClient productsApiClient,
        ICategoriesApiClient categoriesApiClient)
    {
        _logger = logger;
        _productsApiClient = productsApiClient;
        _categoriesApiClient = categoriesApiClient;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _productsApiClient.GetProductsAsync();
        ViewData["Categories"] = await _categoriesApiClient.GetCategoriesAsync();
        return View(new HomeViewModel
        {
            Products = products
        });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
