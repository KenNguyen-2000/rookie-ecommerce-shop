using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Application.Handlers.Categories.GetByName
{
    public class GetCategoryByNameQueryHandler : IRequestHandler<GetCategoryByNameQuery, Result<CategoryVM>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoryByNameQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result<CategoryVM>> Handle(GetCategoryByNameQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryByNameAsync(request.CategoryName);

            if (category == null)
            {
                throw new NotFoundException($"Category with name {request.CategoryName} not found");
            }

            return Result.Ok(new CategoryVM
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ParentId = category.CategoryId,
                SubCategories = category.SubCategories.Select(c => new CategoryVM
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