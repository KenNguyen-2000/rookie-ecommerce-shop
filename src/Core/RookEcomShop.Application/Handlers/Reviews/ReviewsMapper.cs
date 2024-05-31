using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Reviews
{
    public static class ReviewsMapper
    {
        public static ReviewDto MapToReviewVM(Review review, Guid productId)
        {
            return new ReviewDto
            {
                Id = review.Id,
                ProductId = productId,
                Rating = review.Rating,
                Content = review.Content,
                CreatedAt = review.CreatedAt,
                UpdatedAt = review.UpdatedAt,
                User = new UserDto
                {
                    Id = review.UserId,
                    FirstName = review.User.FirstName,
                    LastName = review.User.LastName,
                }
            };
        }

        public static PaginatedList<ReviewDto> MapToPaginatedReviewVM(PaginatedList<Review> paginatedReviews, Guid productId)
        {
            return new PaginatedList<ReviewDto>
            {
                Items = paginatedReviews.Items.Select(r => MapToReviewVM(r, productId)).ToList(),
                Page = paginatedReviews.Page,
                PageSize = paginatedReviews.PageSize,
                TotalCount = paginatedReviews.TotalCount
            };
        }
    }
}