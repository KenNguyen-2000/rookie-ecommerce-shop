using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Product;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews.GetList
{
    public class GetReviewsListQueryHandler : IRequestHandler<GetReviewsListQuery, Result<IEnumerable<ReviewVM>>>
    {
        private readonly IReviewRepository _reviewRepository;

        public GetReviewsListQueryHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Result<IEnumerable<ReviewVM>>> Handle(GetReviewsListQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _reviewRepository.GetListAsync(r => r.Product.Id == request.ProductId, cancellationToken);

            return Result.Ok(reviews.Select(r => new ReviewVM
            {
                ProductId = request.ProductId,
                Rating = r.Rating,
                Content = r.Content,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                User = new UserVM
                {
                    Id = r.User.Id,
                    FirstName = r.User.FirstName,
                    LastName = r.User.LastName,
                    Email = r.User.Email
                }
            }));
        }
    }
}