﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
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
    [Route("api/v1/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _sender;

        public ProductsController(IMediator sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm] CreateProductRequest product)
        {
            var command = new CreateProductCommand
            {
                CategoryId = product.CategoryId,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                UserId = product.UserId,
                Images = product.Images
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
            var query = new GetProductByIdQuery{ Id = id };

            var product = await _sender.Send(query);

            return Ok(new Response<ProductVM>(product, $"Get products by id {id} successfully"));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductByIdCommand { Id = id };
            await _sender.Send(command);

            return Ok("Delete product successfully!");

        }

        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateProductStatus(int id, [FromQuery] ProductStatus status)
        {
            var command = new UpdateProductStatusCommand { Id = id, Status = status };

            await _sender.Send(command);

            return Ok("Update product status successfully!");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductById(int id, [FromBody] UpdateProductRequest updateProductRequest)
        {
            var command = new UpdateProductCommand
            {
                Id = id,
                Name = updateProductRequest.Name,
                Description = updateProductRequest.Description,
                Price = updateProductRequest.Price,
                Status = updateProductRequest.Status,
                StockQuantity = updateProductRequest.StockQuantity
            };

            await _sender.Send(command);

            return Ok("Update product successfully!");
        }
    }
}