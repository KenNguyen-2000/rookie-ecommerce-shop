using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RookEcomShop.Application.Dto;
using RookEcomShop.CustomerFrontend.Models;
using RookEcomShop.CustomerFrontend.Models.Home;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.ViewModels.Dto;
using Serilog;
using System.Diagnostics;

namespace RookEcomShop.CustomerFrontend.Controllers;

public class HomeController : Controller
{
    private readonly IProductsApiClient _productsApiClient;
    private readonly ICategoriesApiClient _categoriesApiClient;

    public HomeController(
        IProductsApiClient productsApiClient,
        ICategoriesApiClient categoriesApiClient)
    {
        _productsApiClient = productsApiClient;
        _categoriesApiClient = categoriesApiClient;
    }

    public async Task<IActionResult> Index([FromQuery] ProductQueryDto? queryDto = null)
    {

        queryDto ??= new ProductQueryDto { PageSize = 5, Page = 1 };

        Log.Information("[HomeController]: Get products from API " + JsonConvert.SerializeObject(queryDto));

        PaginatedList<ProductDto> products = await _productsApiClient.GetProductsAsync(queryDto);

        SetUrlParams(queryDto);

        return View(new HomeViewModel
        {
            ProductDatas = products

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
