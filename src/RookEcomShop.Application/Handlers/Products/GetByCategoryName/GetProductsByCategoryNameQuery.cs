using FluentResults;
using MediatR;
using RookEcomShop.Application.Dto;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQuery : IRequest<Result<PaginatedList<ProductVM>>>
    {
        public string CategoryName { get; set; } = null!;
        public string? SearchTerm;
        public string? SortColumn;
        public string? SortOrder;
        public int Page;
        public int PageSize;
    }
}
