using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Categories.Create
{
    internal class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Result>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(CreateCategoryCommand command, CancellationToken cancellationToken)
        {

            await CreateCategoryAsync(command);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task CreateCategoryAsync(CreateCategoryCommand command)
        {
            var category = await _categoryRepository.GetCategoryByNameAsync(command.Name);

            if (category != null)
                throw new BadRequestException($"Category with name {command.Name} already existed!");

            var newCategory = new Category
            {
                Name = command.Name,
                Description = command.Description
            };
            if (command.ParentId.HasValue)
            {
                var parentCategory = await _categoryRepository.GetCategoryByIdAsync(command.ParentId.Value);

                if (parentCategory == null)
                    throw new NotFoundException($"Category with id {command.ParentId.Value} not found!");

                newCategory.CategoryId = parentCategory.Id;
            }
            _categoryRepository.Create(newCategory);
        }
    }
}
