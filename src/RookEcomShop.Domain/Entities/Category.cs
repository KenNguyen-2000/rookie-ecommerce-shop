using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<Category> SubCategories { get; set; } = new List<Category>();
    }
}