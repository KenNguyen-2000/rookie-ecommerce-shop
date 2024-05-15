using RookEcomShop.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryVM>> GetCategories(CancellationToken cancellation = default);
        Task CreateCategory(CreateCategoryRequest createCategoryRequest);
    }
}
