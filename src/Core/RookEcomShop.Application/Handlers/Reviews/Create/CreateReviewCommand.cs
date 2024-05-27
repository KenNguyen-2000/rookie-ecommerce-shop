using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews.Create
{
    public class CreateReviewCommand : CreateReviewRequest, IRequest<Result>
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }

}