using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    public class CartDetail : ViewComponent
    {
        public IViewComponentResult Invoke(CartDetailVM cartDetail)
        {
            return View(cartDetail);
        }
    }
}