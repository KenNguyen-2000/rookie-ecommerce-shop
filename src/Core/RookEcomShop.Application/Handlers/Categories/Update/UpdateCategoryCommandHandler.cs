using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Categories.Update;

public class UpdateCategoryCommandHandler : BaseService, IRequestHandler<UpdateCategoryCommand, Result>
{
    private readonly ICategoryRepository _categoryRepository;

    public UpdateCategoryCommandHandler(
        ICategoryRepository categoryRepository,
        IUnitOfWork unitOfWork,
        IDateTimeProvider dateTimeProvider) : base(unitOfWork, dateTimeProvider)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Result> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository
                                .GetCategoryByIdAsync(request.Id, cancellationToken)
                                .ThrowIfNullAsync($"Category with id {request.Id}");

        category.Name = request.Name;
        category.Description = request.Description;

        if (request.ParentId.HasValue)
        {
            await _categoryRepository
                        .GetCategoryByIdAsync(request.ParentId.Value, cancellationToken)
                        .ThrowIfNullAsync($"Parent category with id {request.ParentId}");

            category.CategoryId = request.ParentId;
        }
        category.UpdatedAt = _dateTimeProvider.UtcNow;
        await _unitOfWork.SaveAsync(cancellationToken);

        return Result.Ok();
    }
}
