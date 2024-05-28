using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews.Create
{
    public class CreateReviewCommand : CreateReviewRequest, IRequest<Result>
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }

}