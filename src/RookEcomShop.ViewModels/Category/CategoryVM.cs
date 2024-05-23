namespace RookEcomShop.ViewModels.Category
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public IEnumerable<CategoryVM> SubCategories { get; set; } = new List<CategoryVM>();
    }
}
