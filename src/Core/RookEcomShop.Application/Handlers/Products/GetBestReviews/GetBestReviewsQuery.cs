using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetBestReviews
{
    public class GetBestReviewsQuery : IRequest<Result<IEnumerable<ProductDto>>>
    {
        public int Count { get; set; }
    }
}