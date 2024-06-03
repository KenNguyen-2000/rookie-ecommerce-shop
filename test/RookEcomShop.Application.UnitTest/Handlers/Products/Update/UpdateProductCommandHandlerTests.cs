using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Products.Update;
using RookEcomShop.Application.Services;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.Update;

public class UpdateProductCommandHandlerTests
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly Mock<ICategoryRepository> _mockCategoryRepository;
    private readonly Mock<IFileStorageService> _mockFileStorageService;
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly UpdateProductCommandHandler _handler;

    public UpdateProductCommandHandlerTests()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _mockCategoryRepository = new Mock<ICategoryRepository>();
        _mockFileStorageService = new Mock<IFileStorageService>();
        _mockUnitOfWork = new Mock<IUnitOfWork>();
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
        var command = new UpdateProductCommand
        {
            Id = Guid.NewGuid(),
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 19.99m,
            StockQuantity = 50,
            CategoryName = "Updated Category",
            Status = ProductStatus.Active
        };

        var existingProduct = new Product
        {
            Id = command.Id,
            Name = "Existing Product",
            Description = "Existing Description",
            Price = 9.99m,
            StockQuantity = 100,
            Status = ProductStatus.Inactive,
            Category = new Category { Id = Guid.NewGuid(), Name = "Existing Category" },
            ProductImages = new List<ProductImage>()
        };

        var category = new Category
        {
            Id = Guid.NewGuid(),
            Name = "Updated Category"
        };


        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()))
          .ReturnsAsync(existingProduct);

        _mockCategoryRepository.Setup(repo => repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()))
            .ReturnsAsync(category);
        // Act
        var result = await _handler.Handle(command, new CancellationToken());

        // Assert
        result.Should().NotBeNull();
        Assert.True(result.IsSuccess);

        _mockProductRepository.Verify(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()), Times.Once);
        _mockCategoryRepository.Verify(repo => repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()), Times.Once);

        // Verify the product's properties are updated correctly
        existingProduct.Name.Should().Be(command.Name);
        existingProduct.Description.Should().Be(command.Description);
        existingProduct.Price.Should().Be(command.Price);
        existingProduct.StockQuantity.Should().Be(command.StockQuantity);
        existingProduct.Status.Should().Be(command.Status);
        existingProduct.Category.Should().Be(category);
        _mockUnitOfWork.Verify(uow => uow.SaveAsync(It.IsAny<CancellationToken>()), Times.Once);

    }

    [Fact]
    public async Task Handle_ShouldThrowNotFoundException_WhenProductDoesNotExist()
    {
        // Arrange
        var command = new UpdateProductCommand
        {
            Id = Guid.NewGuid(),
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 19.99m,
            StockQuantity = 50,
            CategoryName = "Updated Category",
            Status = ProductStatus.Active
        };

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
        var command = new UpdateProductCommand
        {
            Id = Guid.NewGuid(),
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 19.99m,
            StockQuantity = 50,
            CategoryName = "Updated Category",
            Status = ProductStatus.Active
        };

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, CancellationToken.None))
                .ReturnsAsync(new Product());
        _mockCategoryRepository.Setup(repo => repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()))
                .ReturnsAsync((Category?)null);

        // Act
        var act = async () => await _handler.Handle(command, It.IsAny<CancellationToken>());

        // Assert
        _mockProductRepository.Verify(repo => repo.GetByIdAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()), Times.Once);
        await act.Should().ThrowAsync<NotFoundException>()
                            .WithMessage($"Category with name {command.CategoryName} not found!");
    }

    [Fact]
    public async Task Handle_ShouldUpdateProductImages_WhenNewImagesAreProvided()
    {
        // Arrange
        var command = new UpdateProductCommand
        {
            Id = Guid.NewGuid(),
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 19.99m,
            StockQuantity = 50,
            CategoryName = "Updated Category",
            Status = ProductStatus.Active,
            Images = new FormFileCollection()
            {
                new FormFile(new MemoryStream(), 0, 0, "Data", "image1.jpg"),
                new FormFile(new MemoryStream(), 0, 0, "Data", "image2.jpg")
            }
        };

        var existingProduct = new Product
        {
            Id = command.Id,
            Name = "Existing Product",
            Description = "Existing Description",
            Price = 9.99m,
            StockQuantity = 100,
            Status = ProductStatus.Inactive,
            Category = new Category { Id = Guid.NewGuid(), Name = "Existing Category" },
            ProductImages = new List<ProductImage>
            {
                new ProductImage { Url = "oldimage1.jpg" },
                new ProductImage { Url = "oldimage2.jpg" }
            }
        };

        var category = new Category
        {
            Id = Guid.NewGuid(),
            Name = "Updated Category"
        };

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>()))
                    .ReturnsAsync(existingProduct);

        _mockCategoryRepository.Setup(repo => repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>()))
                    .ReturnsAsync(category);

        _mockFileStorageService.Setup(fss => fss.SaveFileAsync(It.IsAny<IFormFile>())).ReturnsAsync("newImage.jpg");

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        Assert.True(result.IsSuccess);

        _mockFileStorageService.Verify(fss => fss.DeleteFileAsync(It.IsAny<string>()), Times.Exactly(2));
        _mockFileStorageService.Verify(fss => fss.SaveFileAsync(It.IsAny<IFormFile>()), Times.Exactly(2));

        // Verify the product's properties are updated correctly
        existingProduct.Id.Should().Be(command.Id);
        existingProduct.ProductImages.Count.Should().Be(2);
        existingProduct.ProductImages.All(pI => pI.Url == "newImage.jpg");

        _mockUnitOfWork.Verify(uow => uow.SaveAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Handle_ShouldNotUpdateProductImages_WhenNoNewImagesAreProvided()
    {
        // Arrange
        var command = new UpdateProductCommand
        {
            Id = Guid.NewGuid(),
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 19.99m,
            StockQuantity = 50,
            CategoryName = "Updated Category",
            Status = ProductStatus.Active
        };

        var existingProduct = new Product
        {
            Id = command.Id,
            Name = "Existing Product",
            Description = "Existing Description",
            Price = 9.99m,
            StockQuantity = 100,
            Status = ProductStatus.Inactive,
            Category = new Category { Id = Guid.NewGuid(), Name = "Existing Category" },
            ProductImages = new List<ProductImage>
            {
                new ProductImage { Url = "oldimage1.jpg" },
                new ProductImage { Url = "oldimage2.jpg" }
            }
        };

        var category = new Category
        {
            Id = Guid.NewGuid(),
            Name = "Updated Category"
        };

        _mockProductRepository.Setup(repo => repo.GetByIdAsync(command.Id, It.IsAny<CancellationToken>())).ReturnsAsync(existingProduct);
        _mockCategoryRepository.Setup(repo => repo.GetCategoryByNameAsync(command.CategoryName, It.IsAny<CancellationToken>())).ReturnsAsync(category);

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        Assert.True(result.IsSuccess);

        _mockProductRepository.Verify(repo => repo.GetByIdAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()), Times.Once);
        _mockCategoryRepository.Verify(repo => repo.GetCategoryByNameAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);

        // Verify that no execution from FileStorageService
        _mockFileStorageService.Verify(fss => fss.DeleteFileAsync(It.IsAny<string>()), Times.Never);
        _mockFileStorageService.Verify(fss => fss.SaveFileAsync(It.IsAny<IFormFile>()), Times.Never);

        // Verify that the existing product images remain unchanged
        existingProduct.ProductImages.Should().HaveCount(2);
        existingProduct.ProductImages.Should().Contain(p => p.Url == "oldimage1.jpg");
        existingProduct.ProductImages.Should().Contain(p => p.Url == "oldimage2.jpg");

        _mockUnitOfWork.Verify(uow => uow.SaveAsync(It.IsAny<CancellationToken>()), Times.Once);
    }
}