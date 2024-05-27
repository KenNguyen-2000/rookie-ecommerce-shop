using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Orders;

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
            Console.WriteLine("Create order");
            await _ordersApiClient.CreateOrderAsync();
            return Redirect("/cart");
        }
    }
}