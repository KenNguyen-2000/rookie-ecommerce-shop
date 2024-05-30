using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Categories.Delete
{
    public class DeleteCategoryCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
    }
}