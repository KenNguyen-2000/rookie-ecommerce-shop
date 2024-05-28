using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public interface IReviewsApiClient
    {
        Task<IEnumerable<ReviewVM>> GetReviews(Guid productId);
        Task ReviewProductAsync(ReviewsProductInputModel request);
        Task RemoveReviewAsync(Guid productId, Guid reviewId);
    }
}