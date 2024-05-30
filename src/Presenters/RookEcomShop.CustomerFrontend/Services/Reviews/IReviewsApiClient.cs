using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public interface IReviewsApiClient
    {
        Task<PaginatedList<ReviewVM>> GetReviewsAsync(Guid productId);
        Task ReviewProductAsync(ReviewsProductInputModel request);
        Task RemoveReviewAsync(Guid productId, Guid reviewId);
    }
}