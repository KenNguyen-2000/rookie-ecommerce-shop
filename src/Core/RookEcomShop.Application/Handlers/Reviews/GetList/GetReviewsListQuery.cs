using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews.GetList
{
    public class GetReviewsListQuery : IRequest<Result<PaginatedList<ReviewVM>>>
    {
        public Guid ProductId { get; set; }
        public QueryDto QueryObject { get; set; } = new QueryDto();
    }
}