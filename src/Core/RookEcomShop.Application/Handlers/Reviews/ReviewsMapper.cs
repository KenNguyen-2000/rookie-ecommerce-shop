using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.Application.Handlers.Reviews
{
    public static class ReviewsMapper
    {
        public static ReviewVM MapToReviewVM(Review review, Guid productId)
        {
            return new ReviewVM
            {
                Id = review.Id,
                ProductId = productId,
                Rating = review.Rating,
                Content = review.Content,
                CreatedAt = review.CreatedAt,
                UpdatedAt = review.UpdatedAt,
                User = new UserVM
                {
                    Id = review.UserId,
                    FirstName = review.User.FirstName,
                    LastName = review.User.LastName,
                }
            };
        }

        public static PaginatedList<ReviewVM> MapToPaginatedReviewVM(PaginatedList<Review> paginatedReviews, Guid productId)
        {
            return new PaginatedList<ReviewVM>
            {
                Items = paginatedReviews.Items.Select(r => MapToReviewVM(r, productId)).ToList(),
                Page = paginatedReviews.Page,
                PageSize = paginatedReviews.PageSize,
                TotalCount = paginatedReviews.TotalCount
            };
        }
    }
}