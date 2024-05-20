﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProducts(
            string? searchTerm,
            string? sortOrder,
            string? sortColumn,
            int page = 1,
            int pageSize = 10)
        {
            var query = new GetListProductQuery(searchTerm, sortOrder, sortColumn, page, pageSize);

            var result = await _sender.Send(query);

            return Ok(result.Value);
        }

        [AllowAnonymous]
        [HttpGet("collections/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategoryId(
            string categoryName,
            string? searchTerm,
            string? sortOrder,
            string? sortColumn,
            int page = 1,
            int pageSize = 10)
        {
            var query = new GetProductsByCategoryNameQuery
            {
                CategoryName = categoryName,
                SearchTerm = searchTerm,
                SortOrder = sortOrder,
                SortColumn = sortColumn,
                Page = page,
                PageSize = pageSize
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
