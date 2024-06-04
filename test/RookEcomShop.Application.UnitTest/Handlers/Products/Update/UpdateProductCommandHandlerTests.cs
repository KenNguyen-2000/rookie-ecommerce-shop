using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Products.Update;
using RookEcomShop.Application.Services;
using RookEcomShop.Application.UnitTest.Handlers.Products.TestUtils;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.Update;

public class UpdateProductCommandHandlerTests : TestSetup
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly Mock<ICategoryRepository> _mockCategoryRepository;
    private readonly Mock<IFileStorageService> _mockFileStorageService;
    private readonly UpdateProductCommandHandler _handler;

    public UpdateProductCommandHandlerTests()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _mockCategoryRepository = new Mock<ICategoryRepository>();
        _mockFileStorageService = new Mock<IFileStorageService>();
        _handler = new UpdateProductCommandHandler(
            _mockProductRepository.Object,
            _mockUnitOfWork.Object,
            _mockFileStorageService.Object,
            _mockCategoryRepository.Object);
    }

    [Fact]
    public async Task Handle_ShouldReturnOkResult_WhenCommandIsValid()
    {
        // Arrange
        var command = _fixture.Build<UpdateProductCommand>().Create();
        var existingProduct = _fixture.Build<Product>()
                                        .With(p => p.Id, command.Id)
                                        .Create();
        var category = _fixture.Build<Category>()
                                .With(p => p.Name, command.CategoryName)
                                .Create();

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingProduct);

        _mockCategoryRepository.Setup(repo =>
                repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()))
            .ReturnsAsync(category);

        // Act
        var result = await _handler.Handle(command, new CancellationToken());

        // Assert
        result.Should().NotBeNull();
        Assert.True(result.IsSuccess);

        _mockProductRepository.Verify(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()), Times.Once);
        _mockCategoryRepository.Verify(
            repo => repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()), Times.Once);

        // Verify the product's properties are updated correctly
        VerifyProductPropertiesUpdated(command, category, existingProduct);
        _mockUnitOfWork.Verify(uow => uow.SaveAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Handle_ShouldThrowNotFoundException_WhenProductDoesNotExist()
    {
        // Arrange
        var command = _fixture.Create<UpdateProductCommand>();

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Product?)null);

        // Act
        var act = async () => await _handler.Handle(command, It.IsAny<CancellationToken>());

        // Assert

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage($"Product with id {command.Id} not found!");
    }

    [Fact]
    public async Task Handle_ShouldThrowNotFoundException_WhenCategoryDoesNotExist()
    {
        // Arrange
        var command = _fixture.Create<UpdateProductCommand>();

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, CancellationToken.None))
            .ReturnsAsync(new Product());
        _mockCategoryRepository.Setup(repo =>
                repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Category?)null);

        // Act
        var act = async () => await _handler.Handle(command, It.IsAny<CancellationToken>());

        // Assert
        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage($"Category with name {command.CategoryName} not found!");
        _mockProductRepository.Verify(repo => repo.GetByIdAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task Handle_ShouldUpdateProductImages_WhenNewImagesAreProvided()
    {
        // Arrange
        var files = _fixture.CreateMany<IFormFile>(3);
        var fileCollection = _fixture.Create<FormFileCollection>();
        fileCollection.AddRange([.. files]);
        var command = _fixture.Build<UpdateProductCommand>()
                                .With(p => p.Images, fileCollection)
                                .Create();

        var existingProduct = _fixture.Build<Product>().With(p => p.Id, command.Id).Create();
        var category = _fixture.Build<Category>().With(p => p.Name, command.CategoryName).Create();

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingProduct);

        _mockCategoryRepository.Setup(repo =>
                repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()))
            .ReturnsAsync(category);

        _mockFileStorageService.Setup(fss => fss.DeleteFileAsync(It.IsAny<string>()));
        _mockFileStorageService.Setup(fss => fss.SaveFileAsync(It.IsAny<IFormFile>())).ReturnsAsync("newImage.jpg");

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        Assert.True(result.IsSuccess);


        _mockFileStorageService.Verify(fss => fss.DeleteFileAsync(It.IsAny<string>()), Times.Exactly(existingProduct.ProductImages.Count()));
        _mockFileStorageService.Verify(fss => fss.SaveFileAsync(It.IsAny<IFormFile>()), Times.Exactly(3));
        _mockUnitOfWork.Verify(uow => uow.SaveAsync(It.IsAny<CancellationToken>()), Times.Once);

        // Verify the product's properties are updated correctly
        existingProduct.Id.Should().Be(command.Id);
        VerifyProductImagesUpdated(existingProduct);
    }

    [Fact]
    public async Task Handle_ShouldNotUpdateProductImages_WhenNoNewImagesAreProvided()
    {
        // Arrange
        var command = _fixture.Build<UpdateProductCommand>()
                                .Without(p => p.Images)
                                .Create();
        var existingProduct = _fixture.Create<Product>();
        var oldImages = existingProduct.ProductImages;
        var category = _fixture.Build<Category>()
                                .With(c => c.Name, command.CategoryName).Create();

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingProduct);
        _mockCategoryRepository
            .Setup(repo => repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()))
            .ReturnsAsync(category);

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        Assert.True(result.IsSuccess);

        _mockProductRepository.Verify(repo => repo.GetByIdAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);
        _mockCategoryRepository.Verify(
            repo => repo.GetCategoryByNameAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

        // Verify that no execution from FileStorageService
        _mockFileStorageService.Verify(fss => fss.DeleteFileAsync(It.IsAny<string>()), Times.Never);
        _mockFileStorageService.Verify(fss => fss.SaveFileAsync(It.IsAny<IFormFile>()), Times.Never);

        VerifyProductImagesUnchanged(existingProduct, oldImages);

        _mockUnitOfWork.Verify(uow => uow.SaveAsync(It.IsAny<CancellationToken>()), Times.Once);
    }


    private void VerifyProductPropertiesUpdated(UpdateProductCommand command, Category category, Product existingProduct)
    {
        existingProduct.Name.Should().Be(command.Name);
        existingProduct.Description.Should().Be(command.Description);
        existingProduct.Price.Should().Be(command.Price);
        existingProduct.StockQuantity.Should().Be(command.StockQuantity);
        existingProduct.Status.Should().Be(command.Status);
        existingProduct.Category.Should().Be(category);
    }

    private void VerifyProductImagesUpdated(Product existingProduct)
    {
        existingProduct.ProductImages.Count.Should().Be(3);
        existingProduct.ProductImages.All(pI => pI.Url == "newImage.jpg").Should().BeTrue();
    }

    private void VerifyProductImagesUnchanged(Product existingProduct, IEnumerable<ProductImage> oldImages)
    {
        existingProduct.ProductImages.Should().HaveCount(oldImages.Count());

    }

}