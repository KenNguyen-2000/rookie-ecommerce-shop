namespace RookEcomShop.ViewModels.ViewModels;

public class PaginationVM
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public bool HasNextPage => Page * PageSize < TotalCount;
    public bool HasPreviousPage => Page > 1;
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

    public static PaginationVM Create(int page, int pageSize, int totalCount)
    {
        return new PaginationVM
        {
            Page = page,
            PageSize = pageSize,
            TotalCount = totalCount
        };
    }
}