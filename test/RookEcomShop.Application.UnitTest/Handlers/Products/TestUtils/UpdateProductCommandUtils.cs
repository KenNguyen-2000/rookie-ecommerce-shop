using FluentAssertions;
using Microsoft.AspNetCore.Http.Internal;
using RookEcomShop.Application.Handlers.Products.Update;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.TestUtils;

public class UpdateProductCommandUtils
{
    public static UpdateProductCommand CreateValidUpdateProductCommand()
    {
        return new UpdateProductCommand
        {
            Id = Guid.NewGuid(),
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 19.99m,
            StockQuantity = 50,
            CategoryName = "Updated Category",
            Status = ProductStatus.Active
        };
    }

    public static UpdateProductCommand CreateUpdateProductCommandWithImages()
    {
        return new UpdateProductCommand
        {
            Id = Guid.NewGuid(),
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 19.99m,
            StockQuantity = 50,
            CategoryName = "Updated Category",
            Status = ProductStatus.Active,
            Images = new FormFileCollection
                {
                    new FormFile(new MemoryStream(), 0, 0, "Data", "image1.jpg"),
                    new FormFile(new MemoryStream(), 0, 0, "Data", "image2.jpg")
                }
        };
    }

    public static Product CreateExistingProduct(Guid id)
    {
        return new Product
        {
            Id = id,
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

    public static Category CreateCategory(string name)
    {
        return new Category
        {
            Id = Guid.NewGuid(),
            Name = name
        };
    }



    public void VerifyProductImagesUpdated(Product existingProduct)
    {
        existingProduct.ProductImages.Count.Should().Be(2);
        existingProduct.ProductImages.All(pI => pI.Url == "newImage.jpg").Should().BeTrue();
    }


}