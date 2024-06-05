using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RookEcomShop.Application.Dto;
using RookEcomShop.CustomerFrontend.Models;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.ViewModels.ViewModels;
using Serilog;
using System.Diagnostics;

namespace RookEcomShop.CustomerFrontend.Controllers;

[Route("collections")]
public class CollectionsController : Controller
{
    private readonly IProductsApiClient _productsApiClient;
    private readonly ICategoriesApiClient _categoriesApiClient;

    public CollectionsController(
        IProductsApiClient productsApiClient,
        ICategoriesApiClient categoriesApiClient)
    {
        _productsApiClient = productsApiClient;
        _categoriesApiClient = categoriesApiClient;
    }

    [HttpGet("{categoryName}")]
    public async Task<ViewResult> Details(string categoryName, [FromQuery] ProductQueryDto queryDto)
    {

        Log.Information("[CollectionsController]: Get category from API " + categoryName);
        ViewBag.CategoryName = categoryName;
        var category = await _categoriesApiClient.GetCategoryByNameAsync(categoryName);

        if (category == null)
        {
            return View("NotFound");
        }

        queryDto.CategoryName = categoryName;
        queryDto.PageSize = 8;

        Log.Information("[CollectionsController]: Get products from API " + JsonConvert.SerializeObject(queryDto));
        var products = await _productsApiClient.GetProductsAsync(queryDto);

        SetUrlParams(queryDto);

        return View(new CollectionsVM
        {
            Category = category,
            Products = products
        });
    }

    private void SetUrlParams(ProductQueryDto queryDto)
    {
        ViewBag.SearchTerm = queryDto.SearchTerm;
        ViewBag.SortColumn = queryDto.SortColumn;
        ViewBag.SortOrder = queryDto.SortOrder;
        ViewBag.Page = queryDto.Page;
        ViewBag.PageSize = queryDto.PageSize;
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
