using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Categories.Delete
{
    public class DeleteCategoryCommandHandler : BaseService, IRequestHandler<DeleteCategoryCommand, Result>
    {
        private readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository
                                    .GetCategoryByIdAsync(request.Id, cancellationToken)
                                    .ThrowIfNull($"Category with id {request.Id}");

            _categoryRepository.Delete(category!);
            await _unitOfWork.SaveAsync(cancellationToken);
            return Result.Ok();
        }
    }
}