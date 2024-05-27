namespace RookEcomShop.Application.Dto
{
    public class QueryDto
    {
        public string? SearchTerm { get; set; }
        public string? SortOrder { get; set; }
        public string? SortColumn { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}