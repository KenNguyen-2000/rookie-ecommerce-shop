using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Dto;
using RookEcomShop.Application.Handlers.Products.Create;
using RookEcomShop.Application.Handlers.Products.DeleteById;
using RookEcomShop.Application.Handlers.Products.GetByCategoryName;
using RookEcomShop.Application.Handlers.Products.GetById;
using RookEcomShop.Application.Handlers.Products.GetList;
using RookEcomShop.Application.Handlers.Products.PatchStatus;
using RookEcomShop.Application.Handlers.Products.Update;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Api.Controllers.v1
{
    [Authorize]
    [Route("api/v1/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _sender;
        private readonly UserContext _userContext;

        public ProductsController(IMediator sender, UserContext userContext)
        {
            _sender = sender;
            _userContext = userContext;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm] CreateProductRequest product)
        {
            var command = new CreateProductCommand
            {
                CategoryName = product.CategoryName,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                Images = product.Images,
                UserId = _userContext.UserId
            };

            await _sender.Send(command);

            return Created();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] QueryDto? queryDto)
        {
            var query = new GetListProductQuery(queryDto);

            var result = await _sender.Send(query);

            return Ok(result.Value);
        }

        [AllowAnonymous]
        [HttpGet("collections/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategoryId(
            string categoryName,
            [FromQuery] QueryDto queryDto)
        {
            var query = new GetProductsByCategoryNameQuery
            {
                CategoryName = categoryName,
                QueryObject = queryDto
            };

            var result = await _sender.Send(query);
            return Ok(result.Value);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var query = new GetProductByIdQuery { Id = id };

            var result = await _sender.Send(query);

            return Ok(result.Value);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductByIdCommand { Id = id };
            await _sender.Send(command);

            return Ok("Delete product successfully!");

        }

        [Authorize(Roles = "Admin")]
        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateProductStatus(int id, [FromQuery] ProductStatus status)
        {
            var command = new UpdateProductStatusCommand { Id = id, Status = status };

            await _sender.Send(command);

            return Ok("Update product status successfully!");
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductById(int id, [FromForm] UpdateProductRequest updateProductRequest)
        {
            var command = new UpdateProductCommand
            {
                Id = id,
                Name = updateProductRequest.Name,
                Description = updateProductRequest.Description,
                Price = updateProductRequest.Price,
                Status = updateProductRequest.Status,
                StockQuantity = updateProductRequest.StockQuantity,
                Images = updateProductRequest.Images
            };

            await _sender.Send(command);

            return Ok("Update product successfully!");
        }
    }
}
