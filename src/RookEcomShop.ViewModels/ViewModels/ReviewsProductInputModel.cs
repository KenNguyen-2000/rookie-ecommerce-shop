using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.ViewModels.ViewModels
{
    public class ReviewsProductInputModel
    {
        public Guid ProductId { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string Content { get; set; } = null!;

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}