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
            ImgUrls = product.ProductImages.Select(i => i.Url).ToList()
        };
    }

    public static PaginatedList<ProductDto> MapToPaginatedProductVM(PaginatedList<Product> paginatedProducts)
    {
        return new PaginatedList<ProductDto>
        {
            Items = paginatedProducts.Items.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                Status = p.Status,
                Category = new CategoryDto
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name,
                    Description = p.Category.Description,
                    ParentId = p.Category.CategoryId
                },
                ImgUrls = p.ProductImages.Select(i => i.Url).ToList()
            }).ToList(),
            Page = paginatedProducts.Page,
            PageSize = paginatedProducts.PageSize,
            TotalCount = paginatedProducts.TotalCount
        };
    }
}