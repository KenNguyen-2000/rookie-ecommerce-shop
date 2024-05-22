using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    [ViewComponent(Name = "CartDetail")]
    public class CartDetailViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CartDetailVM cartDetail)
        {
            return View(cartDetail);
        }
    }
}