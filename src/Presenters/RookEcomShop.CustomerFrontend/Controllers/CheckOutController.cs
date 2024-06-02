using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RookEcomShop.CustomerFrontend.Models.Checkout;
using RookEcomShop.CustomerFrontend.Services.Cart;
using RookEcomShop.CustomerFrontend.Services.Orders;
using RookEcomShop.ViewModels.Contracts.Order;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Authorize]
    public class CheckOutController : Controller
    {
        private readonly ICartApiClient _cartApiClient;
        private readonly IOrdersApiClient _orderApiClient;

        public CheckOutController(ICartApiClient cartApiClient, IOrdersApiClient orderApiClient)
        {
            _cartApiClient = cartApiClient;
            _orderApiClient = orderApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var cartItems = await _cartApiClient.GetProductsInCart();
            return View(new CheckoutViewModel
            {
                Items = cartItems,
            });
        }

        [HttpPost]
        public async Task<IActionResult> CheckOutOrder(PaymentTransactionInputModel paymentTransactionInputModel)
        {
            await _orderApiClient.CreateOrderAsync(new CreateOrderRequest
            {
                PaymentInfo = JsonConvert.SerializeObject(paymentTransactionInputModel)
            });

            return RedirectToAction("Index", "Home");
        }
    }
}
