using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Cart;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ICategoriesApiClient _categoriesApiClient;
        private readonly ICartApiClient _cartApiClient;
        public HeaderViewComponent(ICategoriesApiClient categoriesApiClient, ICartApiClient cartApiClient)
        {
            _categoriesApiClient = categoriesApiClient;
            _cartApiClient = cartApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewData["CartCount"] = 0;
            var categories = await _categoriesApiClient.GetCategoriesAsync();
            try
            {

                if (User.Identity?.IsAuthenticated == true)
                {
                    var productsInCart = await _cartApiClient.GetProductsInCart();

                    ViewData["CartCount"] = productsInCart.Count();
                }

                return View(categories.Where(c => c.SubCategories.Any()).ToList().Slice(1, 6));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return View(new List<CategoryDto>(categories));
            }
        }
    }
}