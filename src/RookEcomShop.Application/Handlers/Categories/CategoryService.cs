using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Application.Handlers.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateCategory(CreateCategoryRequest createCategoryRequest)
        {
            var existingCategory = await _categoryRepository.GetCategoryByName(createCategoryRequest.Name);
            if (existingCategory != null)
            {
                throw new BadRequestException("Category already exists");
            }

            Category newCategory = new()
            {
                Name = createCategoryRequest.Name,
                Description = createCategoryRequest.Description ?? ""
            };
            _categoryRepository.Create(newCategory);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<CategoryVM>> GetCategories(CancellationToken cancellation)
        {
            var categories = await _categoryRepository.GetListAsync(cancellationToken: cancellation);

            return categories.Select(c => new CategoryVM
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            });
        }
    }
}
