using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Reviews.GetList
{
    public class GetReviewsListQueryHandler : IRequestHandler<GetReviewsListQuery, Result<PaginatedList<ReviewDto>>>
    {
        private readonly IReviewRepository _reviewRepository;

        public GetReviewsListQueryHandler(IReviewRepository reviewRepository, IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Result<PaginatedList<ReviewDto>>> Handle(GetReviewsListQuery request, CancellationToken cancellationToken)
        {
            PaginatedList<Review> paginatedReviews = await _reviewRepository.GetListAsync(r => r.Product.Id.Equals(request.ProductId), request.QueryObject, cancellationToken);


            return Result.Ok(ReviewsMapper.MapToPaginatedReviewVM(paginatedReviews, request.ProductId));
        }

    }
}