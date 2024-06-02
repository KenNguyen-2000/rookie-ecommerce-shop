using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.ViewModels.ViewModels
{
    public class ReviewsProductInputModel
    {
        public Guid ProductId { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Content must be minimum 5 characters")]
        [MaxLength(200, ErrorMessage = "Content is maximum of 200 characters")]
        public string Content { get; set; } = null!;

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; } = 1;

        public Guid? ReviewId { get; set; }

        public string Action { get; set; } = "create";
    }
}