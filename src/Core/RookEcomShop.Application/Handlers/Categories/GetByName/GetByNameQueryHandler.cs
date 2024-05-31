using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Categories.GetByName
{
    public class GetCategoryByNameQueryHandler : IRequestHandler<GetCategoryByNameQuery, Result<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoryByNameQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result<CategoryDto>> Handle(GetCategoryByNameQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryByNameAsync(request.CategoryName);

            if (category == null)
            {
                throw new NotFoundException($"Category with name {request.CategoryName} not found");
            }

            return Result.Ok(new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ParentId = category.CategoryId,
                SubCategories = category.SubCategories.Select(c => new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ParentId = c.CategoryId
                }).ToList()
            });
        }
    }
}