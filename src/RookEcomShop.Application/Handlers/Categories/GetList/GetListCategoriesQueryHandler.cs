using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Categories.GetList
{
    public class GetListCategoriesQueryHandler : IRequestHandler<GetListCategoriesQuery, IEnumerable<CategoryVM>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetListCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryVM>> Handle(GetListCategoriesQuery query, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetListAsync(cancellationToken: cancellationToken);

            return categories.Select(c => new CategoryVM
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            });
        }
    }
}
