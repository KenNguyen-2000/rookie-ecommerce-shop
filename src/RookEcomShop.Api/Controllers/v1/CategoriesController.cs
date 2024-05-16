using MediatR;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Handlers.Categories.Create;
using RookEcomShop.Application.Handlers.Categories.GetList;
using RookEcomShop.ViewModels.Api;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ISender _sender;

        public CategoriesController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var query = new GetListCategoriesQuery();
            var result = await _sender.Send(query);

            return Ok(new Response<CategoryVM>(datas: result.Value, "Get categories success"));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            var command = new CreateCategoryCommand
            {
                Name = createCategoryRequest.Name,
                Description = createCategoryRequest.Description
            };
            await _sender.Send(command);

            return Created();

        }
    }
}
