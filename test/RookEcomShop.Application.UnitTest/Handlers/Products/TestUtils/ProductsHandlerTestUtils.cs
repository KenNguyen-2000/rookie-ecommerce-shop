using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.TestUtils;

public class ProductsHandlerTestUtils
{
    public static Product CreateExistingProduct(Guid? id = null)
    {
        return new Product
        {
            Id = id ?? new Guid(),
            Name = "Existing Product",
            Description = "Existing Description",
            Price = 9.99m,
            StockQuantity = 100,
            Status = ProductStatus.Inactive,
            Category = new Category { Id = Guid.NewGuid(), Name = "Existing Category" },
            ProductImages = new List<ProductImage>
                {
                    new() { Url = "old-image1.jpg" },
                    new() { Url = "old-image2.jpg" }
                }
        };
    }

    public static Category CreateCategory(Guid? id, string name)
    {
        return new Category
        {
            Id = id ?? Guid.NewGuid(),
            Name = name
        };
    }

}