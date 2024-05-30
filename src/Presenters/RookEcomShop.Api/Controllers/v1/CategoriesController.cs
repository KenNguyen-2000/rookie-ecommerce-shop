using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Handlers.Categories.Create;
using RookEcomShop.Application.Handlers.Categories.Delete;
using RookEcomShop.Application.Handlers.Categories.GetByName;
using RookEcomShop.Application.Handlers.Categories.GetList;
using RookEcomShop.Application.Handlers.Categories.Update;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Api.Controllers.v1
{
    [Authorize]
    [Route("api/v1/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ISender _sender;

        public CategoriesController(ISender sender)
        {
            _sender = sender;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var query = new GetListCategoriesQuery();
            var result = await _sender.Send(query);

            return Ok(result.Value);
        }


        [AllowAnonymous]
        [HttpGet("{categoryName}")]
        public async Task<IActionResult> GetCategoryByNameAsync(string categoryName)
        {
            var query = new GetCategoryByNameQuery
            {
                CategoryName = categoryName
            };
            var result = await _sender.Send(query);

            return Ok(result.Value);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            var command = new CreateCategoryCommand
            {
                Name = createCategoryRequest.Name,
                Description = createCategoryRequest.Description,
                ParentId = createCategoryRequest.ParentId
            };
            await _sender.Send(command);

            return Created();

        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoryAsync(Guid id, [FromBody] UpdateCategoryRequest request)
        {
            var command = new UpdateCategoryCommand
            {
                Id = id,
                Name = request.Name,
                Description = request.Description,
                ParentId = request.ParentId
            };
            await _sender.Send(command);

            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryAsync(Guid id)
        {
            var command = new DeleteCategoryCommand
            {
                Id = id
            };
            await _sender.Send(command);

            return Ok();
        }
    }
}
