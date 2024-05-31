using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Contracts.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews.Update
{
    public class UpdateReviewCommand : UpdateReviewRequest, IRequest<Result>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
}