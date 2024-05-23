using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.CustomerFrontend.Models.Reviews
{
    public class ReviewsProductInputModel
    {
        public int ProductId { get; set; }
        [Required]
        public string Content { get; set; } = null!;
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}