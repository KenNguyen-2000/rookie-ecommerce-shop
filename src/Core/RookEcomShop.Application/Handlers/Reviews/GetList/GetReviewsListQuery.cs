using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews.GetList
{
    public class GetReviewsListQuery : IRequest<Result<IEnumerable<ReviewVM>>>
    {
        public int ProductId { get; set; }
    }
}