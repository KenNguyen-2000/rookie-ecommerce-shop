using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    [ViewComponent(Name = "ProductCard")]
    public class ProductCardVC : ViewComponent
    {
        public IViewComponentResult Invoke(ProductVM product)
        {
            return View(product);
        }
    }
}
