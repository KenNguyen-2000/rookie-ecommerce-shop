using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class Review : BaseEntity
    {
        public string Content { get; set; } = null!;
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
