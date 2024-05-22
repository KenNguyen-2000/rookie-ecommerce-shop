namespace RookEcomShop.ViewModels.Reviews
{
    public class CreateReviewRequest
    {
        public int Rating { get; set; }
        public string Content { get; set; } = null!;
    }
}