using Newtonsoft.Json;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public class ReviewsApiClient : IReviewsApiClient
    {
        private readonly HttpClient _httpClient;

        public ReviewsApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ReviewVM>> GetReviews(int productId)
        {
            var response = await _httpClient.GetAsync($"products/{productId}/reviews");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var reviews = JsonConvert.DeserializeObject<IEnumerable<ReviewVM>>(content)!;
            return reviews;
        }
    }
}