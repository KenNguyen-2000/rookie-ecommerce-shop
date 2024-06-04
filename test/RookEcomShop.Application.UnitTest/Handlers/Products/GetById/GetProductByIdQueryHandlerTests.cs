using AutoFixture;
using FluentAssertions;
using Moq;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Products.GetById;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.GetById;

public class GetProductByIdQueryHandlerTests : TestSetup
{
    private readonly Mock<IProductRepository> _mockProductRepo;
    private readonly GetProductByIdQueryHandler _handler;
    public GetProductByIdQueryHandlerTests()
    {
        _mockProductRepo = new Mock<IProductRepository>();
        _handler = new GetProductByIdQueryHandler(_mockProductRepo.Object);
    }

    [Fact]
    public async Task Handle_ShouldReturnProductDto_WhenProductIdValid()
    {
        // Arrange
        var query = _fixture.Create<GetProductByIdQuery>();
        var existingProduct = _fixture.Build<Product>()
                                        .With(p => p.Id, query.Id)
                                        .Create();

        _mockProductRepo.Setup(repo => repo.GetByIdAsync(query.Id, CancellationToken.None)).ReturnsAsync(existingProduct);

        // Act
        var result = await _handler.Handle(query, CancellationToken.None);

        // Assert
        result.IsSuccess.Should().Be(true);
        _mockProductRepo.Verify(repo => repo.GetByIdAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Handle_ShouldThrowNotFoundException_WhenProductNotExist()
    {
        // Arrange
        var query = _fixture.Create<GetProductByIdQuery>();

        _mockProductRepo.Setup(repo => repo.GetByIdAsync(query.Id, CancellationToken.None)).ReturnsAsync((Product?)null);

        // Act
        var act = async () => await _handler.Handle(query, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<NotFoundException>().WithMessage($"Product with id {query.Id} not found!");

        // Verify function call
        _mockProductRepo.Verify(repo => repo.GetByIdAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}