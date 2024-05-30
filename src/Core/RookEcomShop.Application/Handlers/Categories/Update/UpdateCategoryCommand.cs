using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Categories.Update
{
    public class UpdateCategoryCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}