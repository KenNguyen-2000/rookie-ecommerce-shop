using FluentResults;
using MediatR;


namespace RookEcomShop.Application.Handlers.Reviews.Delete
{
    public class DeleteReviewCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}