namespace RookEcomShop.ViewModels.Dto
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public Guid? ParentId { get; set; }
        public IEnumerable<CategoryDto> SubCategories { get; set; } = new List<CategoryDto>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
