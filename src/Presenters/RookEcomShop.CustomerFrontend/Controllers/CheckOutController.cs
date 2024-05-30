using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Models.Checkout;
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

        public async Task<IActionResult> Index()
        {
            var cartItems = await _cartApiClient.GetProductsInCart();
            return View(new CheckoutViewModel
            {
                Items = cartItems
            });
        }
    }
}
