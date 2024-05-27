using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Application.Handlers.Categories.GetList
{
    public class GetListCategoriesQuery : IRequest<Result<IEnumerable<CategoryVM>>>
    { }
}
