using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Application.Handlers.Categories.GetByName
{
    public class GetCategoryByNameQuery : IRequest<Result<CategoryVM>>
    {
        public string CategoryName { get; set; } = null!;
    }
}