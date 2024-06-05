using AutoFixture;
using FluentAssertions;
using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RookEcomShop.Api.Controllers.v1;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Dto;
using RookEcomShop.Application.Handlers.Products.DeleteById;
using RookEcomShop.Application.Handlers.Products.GetBestReviews;
using RookEcomShop.Application.Handlers.Products.GetBestSellers;
using RookEcomShop.Application.Handlers.Products.GetByCategoryName;
using RookEcomShop.Application.Handlers.Products.GetById;
using RookEcomShop.Application.Handlers.Products.GetList;
using RookEcomShop.Application.Handlers.Products.PatchStatus;
using RookEcomShop.Application.Handlers.Products.Update;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.ViewModels.Contracts.Product;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Api.UnitTest.Controllers;

public class ProductsControllerTests : TestControllerSetup
{
    private readonly ProductsController _controller;

    public ProductsControllerTests()
    {
        _controller = new ProductsController(_mockSender.Object, _mockUserContext);
    }

    [Fact]
    public async Task CreateProduct_ShouldReturnCreatedResult()
    {
        // Arrange
        var productRequest = _fixture.Build<CreateProductRequest>()
                                        .With(req => req.Images, _fixture.Create<FormFileCollection>())
                                        .Create();

        // Act
        var result = await _controller.CreateProduct(productRequest);

        // Assert
        result.Should().BeOfType<CreatedResult>();
    }

    [Fact]
    public async Task GetProducts_ShouldReturnOkResultWithProducts()
    {
        // Arrange
        var queryDto = _fixture.Create<ProductQueryDto>();
        var products = _fixture.Create<PaginatedList<ProductDto>>();
        var result = Result.Ok(products);

        _mockSender.Setup(m => m.Send(It.IsAny<GetListProductQuery>(), default))
            .ReturnsAsync(result);

        // Act
        var actionResult = await _controller.GetProducts(queryDto);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;

        okResult.Value.Should().BeEquivalentTo(products);
    }

    [Fact]
    public async Task GetProductsByCategoryName_ShouldReturnOkResultWithProducts()
    {
        // Arrange
        var queryDto = new ProductQueryDto();
        var categoryName = "Electronics";
        var products = _fixture.CreateMany<ProductDto>(10);
        var paginatedProducts = _fixture.Build<PaginatedList<ProductDto>>()
                                 .With(p => p.Items, products)
                                 .With(p => p.TotalCount, products.Count)
                                 .Create();

        var result = Result.Ok(paginatedProducts);

        _mockSender.Setup(m => m.Send(It.IsAny<GetProductsByCategoryNameQuery>(), default))
            .ReturnsAsync(result);

        // Act
        var actionResult = await _controller.GetProductsByCategoryName(categoryName, queryDto);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;
        okResult.Value.Should().BeEquivalentTo(paginatedProducts);
    }

    [Fact]
    public async Task GetProductById_ShouldReturnOkResultWithProduct()
    {
        // Arrange
        var productId = Guid.NewGuid();
        var product = new ProductDto();
        var result = Result.Ok(product);

        _mockSender.Setup(m => m.Send(It.IsAny<GetProductByIdQuery>(), default))
            .ReturnsAsync(result);

        // Act
        var actionResult = await _controller.GetProductById(productId);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;
        okResult.Value.Should().BeEquivalentTo(product);
    }

    [Fact]
    public async Task DeleteProduct_ShouldReturnOkResult_IfProductDeleted()
    {
        // Arrange
        var productId = Guid.NewGuid();

        _mockSender.Setup(m => m.Send(It.IsAny<DeleteProductByIdCommand>(), default))
            .ReturnsAsync(Result.Ok);

        // Act
        var actionResult = await _controller.DeleteProduct(productId);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;
        okResult.Value.Should().Be("Delete product successfully!");
    }

    [Fact]
    public async Task UpdateProductStatus_ShouldReturnOkResult()
    {
        // Arrange
        var productId = Guid.NewGuid();
        var status = ProductStatus.Active;

        _mockSender.Setup(m => m.Send(It.IsAny<UpdateProductStatusCommand>(), default))
            .ReturnsAsync(Result.Ok);

        // Act
        var actionResult = await _controller.UpdateProductStatus(productId, status);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;
        okResult.Value.Should().Be("Update product status successfully!");
    }

    [Fact]
    public async Task UpdateProductById_ShouldReturnOkResult()
    {
        // Arrange
        var productId = Guid.NewGuid();
        var updateProductRequest = _fixture.Build<UpdateProductRequest>()
                                            .With(req => req.Images, Mock.Of<FormFileCollection>())
                                            .Create();

        _mockSender.Setup(m => m.Send(It.IsAny<UpdateProductCommand>(), default))
            .ReturnsAsync(Result.Ok);

        // Act
        var actionResult = await _controller.UpdateProductById(productId, updateProductRequest);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;
        okResult.Value.Should().Be("Update product successfully!");
    }

    [Fact]
    public async Task GetBestSellers_ShouldReturnOkResultWithProducts()
    {
        // Arrange
        var request = new GetFeatureProductsRequest { Count = 5 };
        var products = _fixture.CreateMany<ProductDto>();
        var result = Result.Ok(products);

        _mockSender.Setup(m => m.Send(It.IsAny<GetBestSellersQuery>(), default))
            .ReturnsAsync(result);

        // Act
        var actionResult = await _controller.GetBestSellers(request);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;

        okResult.Value.Should().NotBeNull();
        okResult.Value.Should().BeEquivalentTo(products);
    }

    [Fact]
    public async Task GetBestReviews_ShouldReturnOkResultWithProducts()
    {
        // Arrange
        var request = new GetFeatureProductsRequest { Count = 5 };
        var products = _fixture.CreateMany<ProductDto>(10);
        var result = Result.Ok(products);

        _mockSender.Setup(m => m.Send(It.IsAny<GetBestReviewsQuery>(), default))
            .ReturnsAsync(result);

        // Act
        var actionResult = await _controller.GetBestReviews(request);

        // Assert
        actionResult.Should().BeOfType<OkObjectResult>();
        var okResult = actionResult as OkObjectResult;
        okResult.Value.Should().BeEquivalentTo(products);
    }
}