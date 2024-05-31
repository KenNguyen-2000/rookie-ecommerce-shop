using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Contracts.Category;

namespace RookEcomShop.Application.Handlers.Categories.Create
{
    public class CreateCategoryCommand : CreateCategoryRequest, IRequest<Result>
    {
    }
}
