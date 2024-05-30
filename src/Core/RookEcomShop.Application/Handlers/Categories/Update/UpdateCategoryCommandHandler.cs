using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.Handlers.Categories.Update;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Result>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDateTimeProvider _dateTimeProvider;

    public UpdateCategoryCommandHandler(
        ICategoryRepository categoryRepository,
        IUnitOfWork unitOfWork,
        IDateTimeProvider dateTimeProvider)
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
        _dateTimeProvider = dateTimeProvider;
    }

    public async Task<Result> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetCategoryByIdAsync(request.Id);
        if (category == null)
        {
            throw new NotFoundException("Category not found");
        }

        category.Name = request.Name;
        category.Description = request.Description;

        if (request.ParentId != null)
        {
            var parentCategory = await _categoryRepository.GetCategoryByIdAsync(request.ParentId.Value);
            if (parentCategory == null)
            {
                throw new NotFoundException("Parent category not found");
            }
            category.CategoryId = request.ParentId;
        }
        category.UpdatedAt = _dateTimeProvider.UtcNow;
        await _unitOfWork.SaveAsync(cancellationToken);

        return Result.Ok();
    }
}
