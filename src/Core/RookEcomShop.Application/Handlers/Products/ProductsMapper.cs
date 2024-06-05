using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products;

public static class ProductsMapper
{
    public static ProductDto MapToProductVM(Product product)
    {
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            StockQuantity = product.StockQuantity,
            Status = product.Status,
            Category = new CategoryDto
            {
                Id = product.Category.Id,
                Name = product.Category.Name,
                Description = product.Category.Description,
                ParentId = product.Category.CategoryId
            },
            ImgUrls = product.ProductImages.Select(i => i.Url).ToList(),
            CreatedAt = product.CreatedAt,
            UpdatedAt = product.UpdatedAt
        };
    }

    public static PaginatedList<ProductDto> MapToPaginatedProductVM(PaginatedList<Product> paginatedProducts)
    {
        return new PaginatedList<ProductDto>
        {
            Items = paginatedProducts.Items.Select(MapToProductVM).ToList(),
            Page = paginatedProducts.Page,
            PageSize = paginatedProducts.PageSize,
            TotalCount = paginatedProducts.TotalCount
        };
    }
}