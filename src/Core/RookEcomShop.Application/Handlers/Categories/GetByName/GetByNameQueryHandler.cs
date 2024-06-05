using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Persistence.Repositories;
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
            var category = await _categoryRepository
                                    .GetCategoryByNameAsync(request.CategoryName, cancellationToken)
                                    .ThrowIfNullAsync($"Category with name {request.CategoryName}");

            return Result.Ok(CategoriesMapper.MapToCategoryDto(category));
        }
    }
}