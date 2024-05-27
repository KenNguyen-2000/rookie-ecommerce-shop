using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public interface IReviewsApiClient
    {
        Task<IEnumerable<ReviewVM>> GetReviews(int productId);
        Task ReviewProductAsync(ReviewsProductInputModel request);
        Task RemoveReviewAsync(int productId, int reviewId);
    }
}