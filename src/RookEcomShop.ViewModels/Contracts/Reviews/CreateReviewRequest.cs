using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.ViewModels.Contracts.Reviews
{
    public class CreateReviewRequest
    {
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        [MaxLength(500)]
        public string Content { get; set; } = null!;
    }
}