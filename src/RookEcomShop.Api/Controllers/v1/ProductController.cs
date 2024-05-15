using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Services.ProductService;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;
using System.Net;

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
                await _productService.CreateProductAsync(product);
                return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] string? searchTerm)
        {
            IEnumerable<ProductVM> products = await _productService.GetProductsAsync(searchTerm);
            return Ok(new Response<ProductVM>(datas: products, "Get products successfully", products.Count()));
        }

        [HttpGet("collections/{categoryId}")]
        public async Task<IActionResult> GetProductsByCategoryId(int categoryId)
        {
            var products = await _productService.GetProductByCategoryIdAsync(categoryId);
            return Ok(new Response<ProductVM>(datas: products, $"Get products by categoryId {categoryId} successfully", products.Count()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
                var product = await _productService.GetProductByIdAsync(id);
                return Ok(new Response<ProductVM>(data: product, $"Get products by categoryId {id} successfully"));
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
