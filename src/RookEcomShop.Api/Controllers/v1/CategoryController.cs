using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Services.CategoryService;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            try
            {
                await Task.CompletedTask;
                await _categoryService.CreateCategory(createCategoryRequest);
                return Created();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
