using AutoFixture;
using AutoFixture.Xunit2;
using FluentAssertions;
using Moq;
using RookEcomShop.Application.Dto;
using RookEcomShop.CustomerFrontend.Controllers;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.ViewModels;

namespace RookEcomShop.CustomerFrontend.UnitTest.Controllers;

public class CollectionsControllerTests : TestBase
{
    private readonly Mock<IProductsApiClient> _productsApiClientMock;
    private readonly Mock<ICategoriesApiClient> _categoriesApiClientMock;
    private readonly CollectionsController _controller;
    public CollectionsControllerTests()
    {
        _productsApiClientMock = new Mock<IProductsApiClient>();
        _categoriesApiClientMock = new Mock<ICategoriesApiClient>();
        _controller = new CollectionsController(_productsApiClientMock.Object, _categoriesApiClientMock.Object);
    }

    [Theory, AutoData]
    public async Task Details_ShouldReturnNotFoundView_WhenCategoryIsNull(string categoryName, ProductQueryDto queryDto)
    {
        // Arrange
        _categoriesApiClientMock.Setup(c => c.GetCategoryByNameAsync(It.IsAny<string>())).ReturnsAsync((CategoryDto?)null);

        // Act
        var result = await _controller.Details(categoryName, queryDto);

        // Assert
        result.Should().NotBeNull();
        result!.ViewName.Should().Be("NotFound");
    }

    [Fact]
    public async Task Details_ShouldReturnViewWithCollectionsVM_WhenCategoryExist(

    )
    {
        // Arrange
        var categoryName = _fixture.Create<string>();
        var productQueryDto = _fixture.Create<ProductQueryDto>();
        var categoryDto = _fixture.Build<CategoryDto>()
                                    .With(c => c.SubCategories, _fixture.CreateMany<CategoryDto>())
                                    .Create();
        var paginatedProducts = _fixture.Create<PaginatedList<ProductDto>>();

        _categoriesApiClientMock.Setup(client => client.GetCategoryByNameAsync(categoryName)).ReturnsAsync(categoryDto);
        _productsApiClientMock.Setup(client => client.GetProductsAsync(productQueryDto)).ReturnsAsync(paginatedProducts);

        // Act
        var result = await _controller.Details(categoryName, productQueryDto);

        // Assert
        result.Should().NotBeNull();
        result.Model.Should().BeOfType<CollectionsVM>();

        var model = result.Model as CollectionsVM;
        model.Should().NotBeNull();
        model!.Category.Should().Be(categoryDto);
        model.Products.Should().Be(paginatedProducts);

        VerifyViewBagQuery(productQueryDto);
    }

    private void VerifyViewBagQuery(ProductQueryDto productQueryDto)
    {
        // Verify that ViewBag properties are set correctly
        productQueryDto.SearchTerm.Should().Be(_controller.ViewBag.SearchTerm);
        productQueryDto.SortColumn.Should().Be(_controller.ViewBag.SortColumn);
        productQueryDto.SortOrder.Should().Be(_controller.ViewBag.SortOrder);
        productQueryDto.Page.Should().Be(_controller.ViewBag.Page);
        productQueryDto.PageSize.Should().Be(_controller.ViewBag.PageSize);
    }
}