using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Cart;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.ViewModels.Cart;
using RookEcomShop.ViewModels.Category;

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
            try
            {
                ViewData["CartCount"] = 0;
                var categories = await _categoriesApiClient.GetCategoriesAsync();
                if (User.Identity.IsAuthenticated)
                {
                    var productsInCart = await _cartApiClient.GetProductsInCart();

                    ViewData["CartCount"] = productsInCart.Count();
                }

                return View(categories);
            }
            catch (System.Exception)
            {

                return View(new List<CategoryVM>());
            }
        }
    }
}