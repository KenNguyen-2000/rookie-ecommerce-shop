using System.Net;
using AutoFixture;
using FluentAssertions;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using RookEcomShop.Application.Dto;
using RookEcomShop.CustomerFrontend.Services.Helpers;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.CustomerFrontend.UnitTest.Extensions;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.UnitTest.Services;

public class ProductsApiClientTests : TestBase
{

    private readonly Mock<HttpMessageHandler> _handlerMock;

    public ProductsApiClientTests()
    {
        _handlerMock = new Mock<HttpMessageHandler>();

    }

    [Fact]
    public async Task GetBestReviewsAsync_ShouldReturnProducts_WhenHttpResponseIsSuccessful()
    {
        // Arrange
        var expectedProducts = _fixture.CreateMany<ProductDto>(5);

        var requestUri = $"{fakeBaseAddress}/products/best-reviews?count={5}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(expectedProducts, HttpStatusCode.OK);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var result = await _productsApiClient.GetBestReviewsAsync(5);

        // Assert
        result.Should().BeEquivalentTo(expectedProducts);
    }

    [Fact]
    public async Task GetBestReviewsAsync_ShouldThrowException_WhenHttpResponseIsNotSuccessful()
    {
        // Arrange
        var requestUri = $"{fakeBaseAddress}/products/best-reviews?count={5}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(null, HttpStatusCode.BadRequest);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var act = async () => await _productsApiClient.GetBestReviewsAsync(5);

        // Act & Assert
        await act.Should().ThrowAsync<HttpRequestException>();
    }

    [Fact]
    public async Task GetBestSellersAsync_ShouldReturnProducts_WhenHttpResponseIsSuccessful()
    {
        // Arrange
        var expectedProducts = _fixture.CreateMany<ProductDto>(5);

        var requestUri = $"{fakeBaseAddress}/products/best-sellers?count={5}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(expectedProducts, HttpStatusCode.OK);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var result = await _productsApiClient.GetBestSellersAsync(5);

        // Assert
        result.Should().BeEquivalentTo(expectedProducts);
    }

    [Fact]
    public async Task GetBestSellersAsync_ShouldThrowException_WhenHttpResponseIsNotSuccessful()
    {
        // Arrange
        var requestUri = $"{fakeBaseAddress}/products/best-sellers?count={5}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(null, HttpStatusCode.BadRequest);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var act = async () => await _productsApiClient.GetBestSellersAsync(5);

        // Act & Assert
        await act.Should().ThrowAsync<HttpRequestException>();
    }


    [Fact]
    public async Task GetProductByIdAsync_ShouldReturnProduct_WhenHttpResponseIsSuccessful()
    {
        // Arrange
        var productId = Guid.NewGuid();
        var expectedProduct = _fixture.Build<ProductDto>()
                                        .With(p => p.Id, productId)
                                        .Create();

        var requestUri = $"{fakeBaseAddress}/products/{productId}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(expectedProduct, HttpStatusCode.OK);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var result = await _productsApiClient.GetProductByIdAsync(productId);

        // Assert
        result.Should().NotBeNull();
        result!.Id.Should().Be(expectedProduct.Id);
    }

    [Fact]
    public async Task GeProductByIdAsync_ShouldThrowException_WhenHttpStatusNotSuccess()
    {
        // Arrange
        var productId = Guid.NewGuid();

        var requestUri = $"{fakeBaseAddress}/products/{productId}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(null, HttpStatusCode.BadRequest);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var act = async () => await _productsApiClient.GetProductByIdAsync(productId);

        // Assert
        await act.Should().ThrowAsync<HttpRequestException>();
    }

    [Fact]
    public async Task GetProductsAsync_ShouldReturnProducts_WhenHttpResponseIsSuccessful()
    {
        // Arrange
        var queryDto = _fixture.Create<ProductQueryDto>();
        var expectedProducts = _fixture.Create<PaginatedList<ProductDto>>();

        var requestUri = $"{fakeBaseAddress}/products?{QueryHelper.ToQueryString(queryDto)}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(expectedProducts, HttpStatusCode.OK);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var result = await _productsApiClient.GetProductsAsync(queryDto);

        // Assert
        result.Should().NotBeNull();
        result.Items.Count().Should().Be(expectedProducts.Items.Count());
        result.TotalCount.Should().Be(expectedProducts.TotalCount);
        result.Items.Count().Should().BeLessThanOrEqualTo(queryDto.PageSize);
        result.Should().BeEquivalentTo(expectedProducts);
    }

    [Fact]
    public async Task GetProductsAsync_ShouldThrowException_WhenHttpResponseIsNotSuccessful()
    {
        // Arrange
        var queryDto = _fixture.Create<ProductQueryDto>();

        var requestUri = $"{fakeBaseAddress}/products?{QueryHelper.ToQueryString(queryDto)}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(null, HttpStatusCode.BadRequest);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var act = async () => await _productsApiClient.GetProductsAsync(queryDto);

        // Assert
        await act.Should().ThrowAsync<HttpRequestException>();
    }

    [Fact]
    public async Task GetProductByCategoryNameAsync_ShouldReturnProduct_WhenHttpResponseIsSuccessful()
    {
        // Arrange
        var category = _fixture.Build<CategoryDto>()
                                .With(p => p.SubCategories, _fixture.CreateMany<CategoryDto>())
                                .Create();
        var queryDto = new QueryDto();
        var products = _fixture.Build<ProductDto>()
                                        .With(p => p.Category, category)
                                        .CreateMany(10);
        var expectedPaginatedProducts = _fixture.Build<PaginatedList<ProductDto>>()
                                        .With(p => p.Items, products)
                                        .Create();

        var requestUri = $"{fakeBaseAddress}/products/collections/{category.Name}?{QueryHelper.ToQueryString(queryDto)}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(expectedPaginatedProducts, HttpStatusCode.OK);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var result = await _productsApiClient.GetProductsByCategoryNameAsync(category.Name, queryDto);

        // Assert
        result.Should().NotBeNull();
        result.Items.Count().Should().Be(expectedPaginatedProducts.Items.Count());
        result.TotalCount.Should().Be(expectedPaginatedProducts.TotalCount);
        result.Items.Count().Should().BeLessThanOrEqualTo(queryDto.PageSize);
        result.Should().BeEquivalentTo(expectedPaginatedProducts);

    }

    [Fact]
    public async Task GeProductByCategoryNameAsync_ShouldThrowException_WhenHttpStatusNotSuccess()
    {
        // Arrange
        var category = _fixture.Build<CategoryDto>()
                                .With(p => p.SubCategories, _fixture.CreateMany<CategoryDto>())
                                .Create();
        var queryDto = new QueryDto();

        var requestUri = $"{fakeBaseAddress}/products/collections/{category.Name}?{QueryHelper.ToQueryString(queryDto)}";
        _handlerMock.SetupSendAsync(HttpMethod.Get, requestUri)
        .ReturnsHttpResponseAsync(null, HttpStatusCode.BadRequest);

        var httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri(fakeBaseAddress)
        };
        var _productsApiClient = new ProductsApiClient(httpClient);

        // Act
        var act = async () => await _productsApiClient.GetProductsByCategoryNameAsync(category.Name, queryDto);

        // Assert
        await act.Should().ThrowAsync<HttpRequestException>();
    }
}