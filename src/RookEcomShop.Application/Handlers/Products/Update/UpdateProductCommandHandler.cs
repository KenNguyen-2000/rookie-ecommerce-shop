using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository.GetByIdAsync(command.Id);

            if (existingProduct == null)
                throw new NotFoundException($"Product with id {command.Id} not found!");

            UpdateProduct(existingProduct, command);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private static void UpdateProduct(Product existingProduct, UpdateProductCommand command)
        {
            existingProduct.Name = command.Name;
            existingProduct.Description = command.Description;
            existingProduct.Price = command.Price;
            existingProduct.Status = command.Status;
            existingProduct.StockQuantity = command.StockQuantity;
        }
    }
}
