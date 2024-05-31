using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Categories.GetList
{
    public class GetListCategoriesQueryHandler : IRequestHandler<GetListCategoriesQuery, Result<IEnumerable<CategoryDto>>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetListCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result<IEnumerable<CategoryDto>>> Handle(GetListCategoriesQuery query, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetListAsync(cancellationToken: cancellationToken);

            return Result.Ok(categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                ParentId = c.CategoryId,
                SubCategories = c.SubCategories.Select(sc => new CategoryDto
                {
                    Id = sc.Id,
                    Name = sc.Name,
                    ParentId = sc.CategoryId,
                    Description = sc.Description,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt
                }),
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            }));
        }
    }
}
