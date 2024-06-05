using AutoFixture;
using FluentAssertions;
using FluentResults;
using Moq;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Dto;
using RookEcomShop.Application.Handlers.Products.GetList;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.GetList
{
    public class CreateProductCommandTest : TestSetup
    {
        private readonly GetListProductQueryHandler _handler;
        private readonly Mock<IProductRepository> _productsRepositoryMock;

        public CreateProductCommandTest()
        {
            _productsRepositoryMock = new Mock<IProductRepository>();
            _handler = new GetListProductQueryHandler(_productsRepositoryMock.Object);
        }

        [Fact]
        public async Task Handle_ShouldReturnPaginatedListOfProductDto_WhenProductsExist()
        {
            // Arrange
            var query = _fixture.Build<GetListProductQuery>().Create();

            var products = _fixture.CreateMany<Product>();

            var expectedPaginatedList = PaginatedList<Product>.Create(products, query.QueryObject.Page, query.QueryObject.PageSize, products.Count());

            _productsRepositoryMock.Setup(repo => repo.GetListAsync(It.IsAny<Expression<Func<Product, bool>>>(), query.QueryObject, It.IsAny<CancellationToken>()))
                .ReturnsAsync(expectedPaginatedList);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            result.Should().NotBeNull();
            result.IsSuccess.Should().BeTrue();

            result.Value.Should().NotBeNull();

            // Verify ProductQuery criteria
            result.Value.Page.Should().Be(query.QueryObject.Page);
            result.Value.PageSize.Should().Be(query.QueryObject.PageSize);

            result.Value.Items.Should().HaveCount(products.Count());

            _productsRepositoryMock.Verify(repo => repo.GetListAsync(It.IsAny<Expression<Func<Product, bool>>>(), It.IsAny<ProductQueryDto>(), It.IsAny<CancellationToken>()), Times.Once);
            // Verify Mapping to Dto
            VerifyMappedDto(products, result);
        }


        [Fact]
        public async Task Handle_ShouldReturnEmptyPaginatedList_WhenNoProductsExist()
        {
            // Arrange
            var query = _fixture.Create<GetListProductQuery>();

            var paginatedList = PaginatedList<Product>.Create(new List<Product>(), query.QueryObject.Page, query.QueryObject.PageSize, 0);

            _productsRepositoryMock.Setup(repo => repo.GetListAsync(It.IsAny<Expression<Func<Product, bool>>>(), query.QueryObject, It.IsAny<CancellationToken>()))
                .ReturnsAsync(paginatedList);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            result.Should().NotBeNull();
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().NotBeNull();
            result.Value.Items.Should().BeEmpty();

            _productsRepositoryMock.Verify(repo => repo.GetListAsync(It.IsAny<Expression<Func<Product, bool>>>(), It.IsAny<ProductQueryDto>(), It.IsAny<CancellationToken>()));

        }

        private static void VerifyMappedDto(IEnumerable<Product> products, Result<PaginatedList<ProductDto>> result)
        {
            var firstProductDto = result.Value.Items.First();
            var firstProduct = products.First();

            firstProductDto.Id.Should().Be(firstProduct.Id);
            firstProductDto.Name.Should().Be(firstProduct.Name);
            firstProductDto.Description.Should().Be(firstProduct.Description);
            firstProductDto.Price.Should().Be(firstProduct.Price);
            firstProductDto.StockQuantity.Should().Be(firstProduct.StockQuantity);
            firstProductDto.Status.Should().Be(firstProduct.Status);
            firstProductDto.Category.Id.Should().Be(firstProduct.Category.Id);
            firstProductDto.Category.Name.Should().Be(firstProduct.Category.Name);
        }

    }
}
