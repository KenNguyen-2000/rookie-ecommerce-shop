using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Orders;
using RookEcomShop.ViewModels.Contracts.Order;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Route("orders")]
    public class OrdersController : Controller
    {
        private readonly IOrdersApiClient _ordersApiClient;

        public OrdersController(IOrdersApiClient ordersApiClient)
        {
            _ordersApiClient = ordersApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder()
        {
            return Redirect("/cart");
        }
    }
}