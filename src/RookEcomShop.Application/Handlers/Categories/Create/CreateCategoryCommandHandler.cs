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
            var category = _categoryRepository.GetCategoryByName(command.Name);

            if (category != null)
                throw new BadRequestException($"Category with name {command.Name} already existed!");
            CreateCategory(command);

            await _unitOfWork.SaveAsync();

            return Result.Ok();
        }

        private void CreateCategory(CreateCategoryCommand command)
        {
            _categoryRepository.Create(new Category
            {
                Name = command.Name,
                Description = command.Description
            });
        }
    }
}
