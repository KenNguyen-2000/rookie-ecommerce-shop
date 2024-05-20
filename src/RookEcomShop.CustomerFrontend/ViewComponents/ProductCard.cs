using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    public class ProductCard : ViewComponent
    {
        public IViewComponentResult Invoke(ProductVM product)
        {
            return View(product);
        }
    }
}
