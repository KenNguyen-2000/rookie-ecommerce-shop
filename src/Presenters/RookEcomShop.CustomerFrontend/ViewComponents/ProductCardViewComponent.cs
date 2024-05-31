using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    [ViewComponent(Name = "ProductCard")]
    public class ProductCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ProductDto product)
        {
            return View(product);
        }
    }
}
