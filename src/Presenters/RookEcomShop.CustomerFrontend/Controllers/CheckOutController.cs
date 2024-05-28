using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Cart;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly ICartApiClient _cartApiClient;

        public CheckOutController(ICartApiClient cartApiClient)
        {
            _cartApiClient = cartApiClient;
        }

        public IActionResult Index()
        {
            var cartItems = _cartApiClient.GetProductsInCart();
            return View();
        }
    }
}
