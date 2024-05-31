using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Categories.GetList
{
    public class GetListCategoriesQuery : IRequest<Result<IEnumerable<CategoryDto>>>
    { }
}
