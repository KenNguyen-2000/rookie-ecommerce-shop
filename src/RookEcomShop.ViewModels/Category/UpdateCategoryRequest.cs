namespace RookEcomShop.ViewModels.Category
{
    public class UpdateCategoryRequest
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Guid? ParentId { get; set; }
    }
}