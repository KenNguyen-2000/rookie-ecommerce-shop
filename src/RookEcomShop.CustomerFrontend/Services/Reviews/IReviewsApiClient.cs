using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public interface IReviewsApiClient
    {
        Task<IEnumerable<ReviewVM>> GetReviews(int productId);
    }
}