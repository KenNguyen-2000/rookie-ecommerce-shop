using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Handlers.Carts.AddProduct;
using RookEcomShop.Application.Handlers.Carts.GetProducts;
using RookEcomShop.Application.Handlers.Carts.RemoveProduct;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/carts")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ISender _sender;

        public CartController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProductsInCart()
        {
            var query = new GetProductsFromCartQuery();
            var result = await _sender.Send(query);
            return Ok(new Response<CartDetailVM>(datas: result.Value ,"Get products in cart succeeded"));
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

        [HttpDelete("products/remove")]
        public async Task<IActionResult> RemoveProductFromCart([FromBody] RemoveProductFromCartRequest request)
        {
            var userContext = 2;
            var command = new RemoveProductCommand
            {
                ProductId = request.ProductId,
                UserId = userContext
            };

            await _sender.Send(command);

            return Ok(new Response<Unit>("Remove product from cart succeeded"));
        }
    }
}
