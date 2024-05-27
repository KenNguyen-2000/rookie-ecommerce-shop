using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Handlers.Carts.AddProduct;
using RookEcomShop.Application.Handlers.Carts.GetProducts;
using RookEcomShop.Application.Handlers.Carts.RemoveProduct;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.Api.Controllers.v1
{
    [Authorize]
    [Route("api/v1/carts")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly UserContext userContext;
        private readonly ISender _sender;

        public CartController(ISender sender, UserContext userContext)
        {
            _sender = sender;
            this.userContext = userContext;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProductsInCart()
        {
            var query = new GetProductsFromCartQuery()
            {
                UserId = userContext.UserId
            };
            var result = await _sender.Send(query);
            return Ok(result.Value);
        }

        [HttpPost("products/add")]
        public async Task<IActionResult> AddProductToCart([FromBody] AddProductToCartRequest request)
        {
            var command = new AddProductToCartCommand
            {
                ProductId = request.ProductId,
                Quantity = request.Quantity
            };
            await _sender.Send(command);
            return Ok(new Response<Unit>("Add product to cart succeeded"));
        }

        [HttpDelete("products/{productId}")]
        public async Task<IActionResult> RemoveProductFromCart(int productId)
        {
            var command = new RemoveProductCommand
            {
                ProductId = productId,
                UserId = userContext.UserId
            };

            await _sender.Send(command);

            return Ok(new Response<Unit>("Remove product from cart succeeded"));
        }
    }
}
