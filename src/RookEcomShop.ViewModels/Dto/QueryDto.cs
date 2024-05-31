namespace RookEcomShop.Application.Dto
{
    public class QueryDto
    {
        public virtual string? SearchTerm { get; set; }
        public virtual string? SortOrder { get; set; }
        public virtual string? SortColumn { get; set; }
        public virtual int Page { get; set; } = 1;
        public virtual int PageSize { get; set; } = 10;
    }
}