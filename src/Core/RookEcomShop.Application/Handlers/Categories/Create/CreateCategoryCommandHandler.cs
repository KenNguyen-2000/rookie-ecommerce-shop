using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Categories.Create
{
    internal class CreateCategoryCommandHandler : BaseService, IRequestHandler<CreateCategoryCommand, Result>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result> Handle(CreateCategoryCommand command, CancellationToken cancellationToken)
        {

            await CreateCategoryAsync(command, cancellationToken);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task CreateCategoryAsync(CreateCategoryCommand command, CancellationToken cancellationToken = default)
        {
            await _categoryRepository
                    .GetCategoryByNameAsync(command.Name, cancellationToken)
                    .ThrowIfAlreadyExists($"Category with name {command.Name}");

            // Check if parent category exists
            if (command.ParentId.HasValue)
            {
                await _categoryRepository
                         .GetCategoryByIdAsync(command.ParentId.Value, cancellationToken)
                         .ThrowIfNull($"Category with id {command.ParentId.Value}");
            }

            _categoryRepository.Create(new Category
            {
                Name = command.Name,
                Description = command.Description,
                CategoryId = command.ParentId
            });
        }
    }
}
