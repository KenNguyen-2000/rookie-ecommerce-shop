using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Categories.GetByName
{
    public class GetCategoryByNameQuery : IRequest<Result<CategoryDto>>
    {
        public string CategoryName { get; set; } = null!;
    }
}