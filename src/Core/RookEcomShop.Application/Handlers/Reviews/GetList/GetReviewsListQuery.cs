using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Reviews.GetList
{
    public class GetReviewsListQuery : IRequest<Result<PaginatedList<ReviewDto>>>
    {
        public Guid ProductId { get; set; }
        public QueryDto QueryObject { get; set; } = new QueryDto();
    }
}