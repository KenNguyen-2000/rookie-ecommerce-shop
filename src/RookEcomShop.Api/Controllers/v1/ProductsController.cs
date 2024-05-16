using MediatR;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Handlers.Products.Create;
using RookEcomShop.Application.Handlers.Products.GetByCategoryName;
using RookEcomShop.Application.Handlers.Products.GetById;
using RookEcomShop.Application.Handlers.Products.GetList;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;

        public ProductsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest product)
        {
            var command = new CreateProductCommand
            {
                CategoryId = product.CategoryId,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                UserId = product.UserId
            };

            await _sender.Send(command);

            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] string? searchTerm)
        {
            var query = new GetListProductQuery { SearchTerm = searchTerm };

            var products = await _sender.Send(query);

            return Ok(new Response<ProductVM>(datas: products, "Get products successfully", products.Count()));
        }

        [HttpGet("collections/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategoryId(string categoryName)
        {
            var query = new GetProductsByCategoryNameQuery { CategoryName = categoryName };

            var products = await _sender.Send(query);
            return Ok(new Response<ProductVM>(datas: products, $"Get products by category {categoryName} successfully", products.Count()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var query = new GetProductByIdQuery(id);

            var product = await _sender.Send(query);

            return Ok(new Response<ProductVM>(product, $"Get products by id {id} successfully"));
        }

        [HttpPatch("{id}/delete")]
        public async Task<IActionResult> SoftDeleteProduct(int id)
        {
            await Task.CompletedTask;
            return Ok();

        }

        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateProductStatus(int id, [FromQuery] string status)
        {
            await Task.CompletedTask;
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductById(int id, [FromQuery] string action)
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
