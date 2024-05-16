using MediatR;
using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.Application.Handlers.Categories.Create
{
    public class CreateCategoryCommand : CreateCategoryRequest, IRequest
    {
    }
}
