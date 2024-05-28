using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class Review : BaseEntity<Guid>
    {
        public string Content { get; set; } = null!;
        public int Rating { get; set; }
        public Guid UserId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
