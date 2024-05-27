using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews.Update
{
    public class UpdateReviewCommand : UpdateReviewRequest, IRequest<Result>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}