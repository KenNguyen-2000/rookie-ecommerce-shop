using FluentResults;
using MediatR;


namespace RookEcomShop.Application.Handlers.Reviews.Delete
{
    public class DeleteReviewCommand : IRequest<Result>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}