using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Reviews;
using RookEcomShop.ViewModels.User;

namespace RookEcomShop.Application.Handlers.Reviews.GetList
{
    public class GetReviewsListQueryHandler : IRequestHandler<GetReviewsListQuery, Result<IEnumerable<ReviewVM>>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;

        public GetReviewsListQueryHandler(IReviewRepository reviewRepository, IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
        }

        public async Task<Result<IEnumerable<ReviewVM>>> Handle(GetReviewsListQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _reviewRepository.GetListAsync(r => r.Product.Id.Equals(request.ProductId), cancellationToken);
            IEnumerable<int> userIds = reviews.Select(r => r.UserId).ToList();
            var users = await _userRepository.GetUsersByIds(userIds);
            IEnumerable<ReviewVM> mergedReviews = MergeUsersToReviews(request, reviews, users);
            return Result.Ok(mergedReviews);
        }

        private static IEnumerable<ReviewVM> MergeUsersToReviews(GetReviewsListQuery request, IEnumerable<Review> reviews, IEnumerable<UserDto> users)
        {
            return reviews.Join(users, r => r.UserId, u => u.Id, (r, u) => new ReviewVM
            {
                Id = r.Id,
                ProductId = request.ProductId,
                Rating = r.Rating,
                Content = r.Content,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                User = new UserVM
                {
                    Id = r.UserId,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                }
            });
        }
    }
}