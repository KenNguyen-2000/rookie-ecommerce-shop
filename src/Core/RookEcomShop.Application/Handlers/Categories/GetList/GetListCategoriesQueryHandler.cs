using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Application.Handlers.Categories.GetList
{
    public class GetListCategoriesQueryHandler : IRequestHandler<GetListCategoriesQuery, Result<IEnumerable<CategoryVM>>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetListCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result<IEnumerable<CategoryVM>>> Handle(GetListCategoriesQuery query, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetListAsync(cancellationToken: cancellationToken);

            return Result.Ok(categories.Select(c => new CategoryVM
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                SubCategories = c.SubCategories.Select(sc => new CategoryVM
                {
                    Id = sc.Id,
                    Name = sc.Name,
                    Description = sc.Description
                })
            }));
        }
    }
}
