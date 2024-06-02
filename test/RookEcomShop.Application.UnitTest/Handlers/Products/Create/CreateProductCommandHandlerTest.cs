using FluentAssertions;
using FluentResults;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using RookEcomShop.Application.Common.Behaviors;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Handlers.Products.Create;
using RookEcomShop.Application.Services;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.UnitTest.Handlers.Products.Create;

public class CreateProductCommandHandlerTest
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly Mock<ICategoryRepository> _mockCategoryRepository;
    private readonly Mock<IFileStorageService> _mockFileStorageService;
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly CreateProductCommandHandler _handler;
    private readonly IValidator<CreateProductCommand> _validator;

    public CreateProductCommandHandlerTest()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _mockCategoryRepository = new Mock<ICategoryRepository>();
        _mockFileStorageService = new Mock<IFileStorageService>();
        _mockUnitOfWork = new Mock<IUnitOfWork>();
        _validator = new CreateProductCommandValidator();
        _handler = new CreateProductCommandHandler(
            _mockProductRepository.Object,
            _mockCategoryRepository.Object,
            _mockUnitOfWork.Object,
            _mockFileStorageService.Object);
    }

    [Fact]
    public async Task Handle_ShouldReturnOkResult_WhenCommandIsValid()
    {
        // Arrange
        var command = new CreateProductCommand
        {
            Name = "Test Product",
            Description = "Test Description",
            Price = 10.99m,
            StockQuantity = 100,
            CategoryName = "Test Category",
            UserId = Guid.NewGuid(),
            Images = null
        };

        var category = new Category { Name = "Test Category" };

        _mockCategoryRepository
            .Setup(repo => repo.GetCategoryByNameAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(category);

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.IsSuccess.Should().BeTrue();
        _mockProductRepository.Verify(repo => repo.Create(It.IsAny<Product>()), Times.Once);
        _mockUnitOfWork.Verify(uow => uow.SaveAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Handle_ShouldReturnFailResult_WhenCategoryNotFound()
    {
        // Arrange
        var command = new CreateProductCommand
        {
            Name = "Test Product",
            Description = "Test Description",
            Price = 10.99m,
            StockQuantity = 100,
            CategoryName = "Invalid Category",
            UserId = Guid.NewGuid(),
            Images = null
        };

        _mockCategoryRepository
            .Setup(repo => repo.GetCategoryByNameAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Category)null);

        // Act
        Func<Task> act = async () => await _handler.Handle(command, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Category with name Invalid Category not found!");
    }

    [Fact]
    public async Task Handle_ShouldSaveImages_WhenImagesProvided()
    {
        var mockImage = new Mock<IFormFile>();
        mockImage.Setup(_ => _.FileName).Returns("test.jpg");
        mockImage.Setup(_ => _.Length).Returns(1);
        mockImage.Setup(_ => _.OpenReadStream()).Returns(new MemoryStream());
        var images = new FormFileCollection { mockImage.Object };
        // Arrange
        var command = new CreateProductCommand
        {
            Name = "Test Product",
            Description = "Test Description",
            Price = 10.99m,
            StockQuantity = 100,
            CategoryName = "Test Category",
            UserId = Guid.NewGuid(),
            Images = images // Add mock images here
        };

        var category = new Category { Name = "Test Category" };

        _mockCategoryRepository
            .Setup(repo => repo.GetCategoryByNameAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(category);

        _mockFileStorageService
            .Setup(service => service.SaveFileAsync(It.IsAny<IFormFile>()))
            .ReturnsAsync("image_path.jpg");

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.IsSuccess.Should().BeTrue();
        _mockFileStorageService.Verify(service => service.SaveFileAsync(It.IsAny<IFormFile>()), Times.AtLeastOnce);
    }

    [Fact]
    public async Task Handle_ShouldReturnFailResult_WhenCommandIsInvalid()
    {
        // Arrange
        var command = new CreateProductCommand
        {
            Name = string.Empty, // Invalid name
            Description = "Test Description",
            Price = 10.99m,
            StockQuantity = 100,
            CategoryName = "Test Category",
            UserId = Guid.NewGuid(),
            Images = null
        };

        var validationBehavior = new ValidationBehavior<CreateProductCommand, Result>(_validator);

        // Act
        Func<Task> act = async () => await validationBehavior.Handle(command, () => _handler.Handle(command, CancellationToken.None), CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<BadRequestException>();
    }
}