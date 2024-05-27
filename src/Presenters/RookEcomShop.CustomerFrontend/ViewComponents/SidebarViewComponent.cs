using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Categories;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    [ViewComponent(Name = "Sidebar")]
    public class SidebarViewComponent : ViewComponent
    {
        private readonly ICategoriesApiClient _categoriesApiClient;
        public SidebarViewComponent(ICategoriesApiClient categoriesApiClient)
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