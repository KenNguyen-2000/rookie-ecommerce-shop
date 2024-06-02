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

            return Result.Ok(categories.Select(CategoriesMapper.MapToCategoryDto));
        }
    }
}
