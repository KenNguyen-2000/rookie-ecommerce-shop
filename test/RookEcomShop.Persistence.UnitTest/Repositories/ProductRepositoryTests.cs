using System.Linq.Expressions;
using AutoFixture;
using AutoFixture.Xunit2;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.Repositories;
using RookEcomShop.Persistence.UnitTest.TestUtils;

namespace RookEcomShop.Persistence.UnitTest.Repositories;

public class ProductRepositoryTests : TestSetup
{

    private RookEcomShopDbContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<RookEcomShopDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var context = new RookEcomShopDbContext(options);

        // Seed the database with initial data if needed
        var categories = _fixture.CreateMany<Category>(3).ToList();
        context.Categories.AddRange(categories);
        Random rnd = new Random();
        var products = _fixture.Build<Product>()
            .With(p => p.Category, categories[0])
            .CreateMany(10).ToList();
        context.Products.AddRange(products);

        context.SaveChanges();

        return context;
    }

    [Fact]
    public async Task GetById_ShouldReturnProduct_IfProductExist()
    {
        // Arrange
        var existingProduct = _fixture.Create<Product>();

        _dbContextMock.Add(existingProduct);
        _dbContextMock.SaveChanges();

        var repository = new ProductRepository(_dbContextMock);

        // Act
        var result = await repository.GetByIdAsync(existingProduct.Id);

        // Assert
        result.Should().NotBeNull();
        result.Id.Should().Be(existingProduct.Id);
        result.Category.Should().NotBeNull();
        result.ProductImages.Should().NotBeNull();
    }

    [Theory, AutoData]
    public async Task GetListAsync_ShouldReturnPaginatedProduct_IfProductExist(ProductQueryDto productQueryDto)
    {
        // Arrange
        using var dbContext = CreateDbContext();
        var repository = new ProductRepository(dbContext);

        // Setting up productQueryDto with matching data
        var existingProduct = dbContext.Products.First();
        productQueryDto.CategoryName = existingProduct.Category.Name;
        productQueryDto.SearchTerm = existingProduct.Name.Substring(0, 3); // partial match
        productQueryDto.Status = existingProduct.Status;

        Expression<Func<Product, bool>>? filter = null;

        // Act
        var result = await repository.GetListAsync(filter, productQueryDto);

        // Assert
        result.Should().NotBeNull();
        result.TotalCount.Should().BeGreaterThan(0);
        result.Items.Count().Should().BeLessThanOrEqualTo(productQueryDto.PageSize);
    }

    [Fact]
    public async Task GetListBestSellersAsync_ShouldReturnBestSellers()
    {
        // Arrange
        using var dbContext = CreateDbContext();
        var repository = new ProductRepository(dbContext);
        var existingProducts = dbContext.Products.ToList();
        var random = new Random();

        foreach (var product in existingProducts)
        {
            var orderDetails = _fixture.Build<OrderDetail>()
                .With(od => od.Product, product)
                .CreateMany(random.Next(1, 20))
                .ToList();
            dbContext.OrderDetails.AddRange(orderDetails);
        }

        await dbContext.SaveChangesAsync();

        // Act
        var result = await repository.GetListBestSellersAsync(5);

        // Assert
        result.Should().NotBeNull();
        result.Count().Should().BeLessThanOrEqualTo(5);
        result.Should().BeInDescendingOrder(p => p.OrderDetails.Count);
    }

    [Fact]
    public async Task GetListBestReviewsAsync_ShouldReturnBestReviewed()
    {
        // Arrange
        using var dbContext = CreateDbContext();
        var repository = new ProductRepository(dbContext);

        // Seed additional products with reviews to ensure the test has varied data
        var products = dbContext.Products.ToList();
        var random = new Random();


        foreach (var product in products)
        {
            var reviews = _fixture.Build<Review>()
                .With(r => r.Product, product)
                .With(r => r.Rating, random.Next(1, 5))
                .CreateMany(random.Next(1, 5))
                .ToList();
            dbContext.Reviews.AddRange(reviews);
            product.Reviews = reviews;
        }

        dbContext.SaveChanges();

        // Act
        var result = await repository.GetListBestReviewsAsync(5);

        // Assert
        result.Should().NotBeNull();
        result.Should().HaveCountLessOrEqualTo(5);

        result.Should().BeInDescendingOrder(p => p.Reviews.Count);
    }
}