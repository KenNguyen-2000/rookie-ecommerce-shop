using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    [ViewComponent(Name = "CartDetail")]
    public class CartDetailViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CartDetailDto cartDetail)
        {
            return View(cartDetail);
        }
    }
}