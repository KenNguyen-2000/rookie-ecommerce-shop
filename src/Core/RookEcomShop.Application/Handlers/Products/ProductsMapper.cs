using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products;

public static class ProductsMapper
{
    public static ProductVM MapToProductVM(Product product)
    {
        return new ProductVM
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            StockQuantity = product.StockQuantity,
            Status = product.Status,
            Category = new CategoryVM
            {
                Id = product.Category.Id,
                Name = product.Category.Name,
                Description = product.Category.Description,
                ParentId = product.Category.CategoryId
            },
            ImgUrls = product.ProductImages.Select(i => i.Url).ToList()
        };
    }

    public static PaginatedList<ProductVM> MapToPaginatedProductVM(PaginatedList<Product> paginatedProducts)
    {
        return new PaginatedList<ProductVM>
        {
            Items = paginatedProducts.Items.Select(p => new ProductVM
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                Status = p.Status,
                Category = new CategoryVM
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