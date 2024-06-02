using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Dto;
using RookEcomShop.Application.Handlers.Products.Create;
using RookEcomShop.Application.Handlers.Products.DeleteById;
using RookEcomShop.Application.Handlers.Products.GetBestReviews;
using RookEcomShop.Application.Handlers.Products.GetBestSellers;
using RookEcomShop.Application.Handlers.Products.GetByCategoryName;
using RookEcomShop.Application.Handlers.Products.GetById;
using RookEcomShop.Application.Handlers.Products.GetList;
using RookEcomShop.Application.Handlers.Products.PatchStatus;
using RookEcomShop.Application.Handlers.Products.Update;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.ViewModels.Contracts.Product;
using RookEcomShop.ViewModels.Dto;

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
                StockQuantity = product.StockQuantity,
                Images = product.Images,
                UserId = _userContext.UserId
            };

            await _sender.Send(command);

            return Created();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] ProductQueryDto? queryDto)
        {
            var query = new GetListProductQuery { QueryObject = queryDto ?? new ProductQueryDto() };

            Result<PaginatedList<ProductDto>> result = await _sender.Send(query);

            return Ok(result.Value);
        }

        [AllowAnonymous]
        [HttpGet("collections/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategoryName(
            string categoryName,
            [FromQuery] ProductQueryDto queryDto)
        {
            var query = new GetProductsByCategoryNameQuery
            {
                CategoryName = categoryName,
                QueryObject = queryDto
            };

            Result<PaginatedList<ProductDto>> result = await _sender.Send(query);
            return Ok(result.Value);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var query = new GetProductByIdQuery { Id = id };

            Result<ProductDto> result = await _sender.Send(query);

            return Ok(result.Value);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var command = new DeleteProductByIdCommand { Id = id };
            await _sender.Send(command);

            return Ok("Delete product successfully!");

        }

        [Authorize(Roles = "Admin")]
        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateProductStatus(Guid id, [FromQuery] ProductStatus status)
        {
            var command = new UpdateProductStatusCommand { Id = id, Status = status };

            await _sender.Send(command);

            return Ok("Update product status successfully!");
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductById(Guid id, [FromForm] UpdateProductRequest updateProductRequest)
        {
            var command = new UpdateProductCommand
            {
                Id = id,
                Name = updateProductRequest.Name,
                Description = updateProductRequest.Description,
                Price = updateProductRequest.Price,
                Status = updateProductRequest.Status,
                StockQuantity = updateProductRequest.StockQuantity,
                Images = updateProductRequest.Images,
                CategoryName = updateProductRequest.CategoryName
            };

            await _sender.Send(command);

            return Ok("Update product successfully!");
        }

        [AllowAnonymous]
        [HttpGet("best-sellers")]
        public async Task<IActionResult> GetBestSellers([FromQuery] GetFeatureProductsRequest request)
        {
            var query = new GetBestSellersQuery { Count = request.Count };
            var result = await _sender.Send(query);

            return Ok(result.Value);
        }

        [AllowAnonymous]
        [HttpGet("best-reviews")]
        public async Task<IActionResult> GetBestReviews([FromQuery] GetFeatureProductsRequest request)
        {
            var query = new GetBestReviewsQuery { Count = request.Count };
            var result = await _sender.Send(query);

            return Ok(result.Value);
        }
    }
}
