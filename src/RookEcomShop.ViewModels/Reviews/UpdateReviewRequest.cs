namespace RookEcomShop.ViewModels.Reviews
{
    public class UpdateReviewRequest
    {
        public int Rating { get; set; }
        public string Content { get; set; } = null!;
    }
}