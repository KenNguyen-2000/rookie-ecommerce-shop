using AutoFixture;
using FluentAssertions;
using Moq;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Products.GetBestReviews;
using RookEcomShop.Application.Handlers.Products.GetBestSellers;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.GetBestSellers;

public class GetBestSellersQueryHandlerTests : TestSetup
{
    private readonly Mock<IProductRepository> _mockProductRepo;
    private readonly GetBestSellersQueryHandler _handler;

    public GetBestSellersQueryHandlerTests()
    {
        _mockProductRepo = new Mock<IProductRepository>();
        _handler = new GetBestSellersQueryHandler(_mockProductRepo.Object);
    }

    [Fact]
    public async Task Handle_ShouldReturnListOfBestSellers_WhenProductsExist()
    {
        // Arrange
        var query = _fixture.Build<GetBestSellersQuery>()
                            .With(p => p.Count, 3)
                            .Create();

        var products = _fixture.CreateMany<Product>(100);


        _mockProductRepo.Setup(repo => repo.GetListBestSellersAsync(query.Count, CancellationToken.None))
            .ReturnsAsync(products.Take(query.Count));

        // Act
        var result = await _handler.Handle(query, CancellationToken.None);

        // Assert
        result.Value.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();

        result.Value.Should().NotBeNull();

        result.Value.Should().HaveCount(query.Count);
    }

    [Fact]
    public async Task Handle_ShouldReturnListOfBestSellers_IfProductsNotExist()
    {
        // Arrange
        var query = _fixture.Build<GetBestSellersQuery>().Create();



        _mockProductRepo.Setup(repo => repo.GetListBestSellersAsync(query.Count, CancellationToken.None))
            .ReturnsAsync([]);

        // Act
        var result = await _handler.Handle(query, CancellationToken.None);

        // Assert
        result.Value.Should().NotBeNull();
        result.IsSuccess.Should().BeTrue();

        result.Value.Should().BeEmpty();
    }
}