
using Microsoft.EntityFrameworkCore;

namespace RookEcomShop.ViewModels.Dto
{
    public class PaginatedList<T>
    {
        public PaginatedList()
        {
        }

        private PaginatedList(IEnumerable<T> items, int page, int pageSize, int totalCount)
        {
            Items = items;
            Page = page;
            PageSize = pageSize;
            TotalCount = totalCount;
        }
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalCount { get; set; } = 0;
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public bool HasNextPage => Page * PageSize < TotalCount;

        public bool HasPreviousPage => Page > 1;

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> query, int page, int pageSize, CancellationToken cancellationToken = default)
        {
            var totalCount = await query.CountAsync();
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);

            return new(items, page, pageSize, totalCount);
        }

        public static PaginatedList<T> Create(IEnumerable<T> items, int page, int pageSize, int totalCount)
        {
            return new(items, page, pageSize, totalCount);
        }
        public static PaginatedList<T> Create(IEnumerable<T> items)
        {
            return new(items, 1, items.Count(), items.Count());
        }
    }
}