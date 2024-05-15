using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Services.ProductService;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest product)
        {
            try
            {
                await _productService.CreateProductAsync(product);
                return Created();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] string? searchTerm)
        {
            var products = await _productService.GetProductsAsync(searchTerm);
            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByCategory([FromQuery] string? searchTerm)
        {
            var products = await _productService.GetProductsAsync(searchTerm);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                var product = await _productService.GetProductByIdAsync(id);
                return Ok(product);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPatch("{id}/delete")]
        public async Task<IActionResult> SoftDeleteProduct(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateProductStatus(int id, [FromQuery] string status)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductById(int id, [FromQuery] string action)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
