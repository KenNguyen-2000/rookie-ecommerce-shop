using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Reviews;
using RookEcomShop.ViewModels.User;

namespace RookEcomShop.Application.Handlers.Reviews.GetList
{
    public class GetReviewsListQueryHandler : IRequestHandler<GetReviewsListQuery, Result<PaginatedList<ReviewVM>>>
    {
        private readonly IReviewRepository _reviewRepository;

        public GetReviewsListQueryHandler(IReviewRepository reviewRepository, IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Result<PaginatedList<ReviewVM>>> Handle(GetReviewsListQuery request, CancellationToken cancellationToken)
        {
            PaginatedList<Review> paginatedReviews = await _reviewRepository.GetListAsync(r => r.Product.Id.Equals(request.ProductId), request.QueryObject, cancellationToken);


            return Result.Ok(ReviewsMapper.MapToPaginatedReviewVM(paginatedReviews, request.ProductId));
        }

    }
}