using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Categories
{
    public static class CategoriesMapper
    {
        public static CategoryDto MapToCategoryDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ParentId = category.CategoryId,
                SubCategories = category.SubCategories.Select(MapToCategoryDto),
                CreatedAt = category.CreatedAt,
                UpdatedAt = category.UpdatedAt
            };
        }
    }
}