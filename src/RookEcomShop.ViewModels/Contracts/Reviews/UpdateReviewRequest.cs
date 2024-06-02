namespace RookEcomShop.ViewModels.Contracts.Reviews
{
    public class UpdateReviewRequest
    {
        public Guid ProductId { get; set; }
        public int Rating { get; set; }
        public string Content { get; set; } = null!;
    }
}