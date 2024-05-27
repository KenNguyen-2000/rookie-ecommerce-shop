using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Handlers.Orders.Cancel;
using RookEcomShop.Application.Handlers.Orders.Confirm;
using RookEcomShop.Application.Handlers.Orders.Create;
using RookEcomShop.Application.Handlers.Orders.GetById;
using RookEcomShop.Application.Handlers.Orders.GetList;

namespace RookEcomShop.Api.Controllers.v1
{
    [Authorize]
    [Route("api/v1/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly UserContext _userContext;

        public OrdersController(ISender sender, UserContext userContext)
        {
            _sender = sender;
            _userContext = userContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderDetail()
        {
            var query = new GetListOrderQuery
            {
                UserId = _userContext.UserId
            };
            var result = await _sender.Send(query);
            return Ok(result.Value);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderDetail(int orderId)
        {
            var query = new GetOrderByIdQuery
            {
                OrderId = orderId
            };
            var result = await _sender.Send(query);
            return Ok(result.Value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder()
        {
            var command = new CreateOrderCommand
            {
                UserId = _userContext.UserId,
            };

            await _sender.Send(command);
            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpPatch("{orderId}/confirm")]
        public async Task<IActionResult> ConfirmOrder(int orderId)
        {
            var command = new ConfirmOrderCommand
            {
                OrderId = orderId
            };

            await _sender.Send(command);
            return Ok();
        }

        [HttpPatch("{orderId}/cancel")]
        public async Task<IActionResult> CancelOrder(int orderId)
        {
            var command = new CancelOrderCommand
            {
                OrderId = orderId
            };

            await _sender.Send(command);
            return Ok();
        }
    }
}
