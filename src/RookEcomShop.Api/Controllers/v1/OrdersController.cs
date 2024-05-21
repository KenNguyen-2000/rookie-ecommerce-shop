using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Handlers.Orders.Create;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.Api.Controllers.v1
{
    [Authorize]
    [Route("api/v1/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ISender _sender;

        public OrdersController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest createOrderRequest)
        {
            var command = new CreateOrderCommand
            {
                CartDetails = createOrderRequest.CartDetails,
            };

            await _sender.Send(command);
            return Ok();
        }


    }
}
