using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ICategoriesApiClient _categoriesApiClient;
        public HeaderViewComponent(ICategoriesApiClient categoriesApiClient)
        {
            _categoriesApiClient = categoriesApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoriesApiClient.GetCategoriesAsync();
            return View(categories);
        }
    }
}