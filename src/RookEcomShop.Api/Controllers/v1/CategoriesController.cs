using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Handlers.Categories.Create;
using RookEcomShop.Application.Handlers.Categories.GetByName;
using RookEcomShop.Application.Handlers.Categories.GetList;
using RookEcomShop.ViewModels.Api;
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
        public async Task<IActionResult> GetCategoryByName(string categoryName)
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
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest createCategoryRequest)
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
    }
}
