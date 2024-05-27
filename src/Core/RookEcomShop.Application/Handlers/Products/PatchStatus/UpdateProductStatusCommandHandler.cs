﻿using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.Handlers.Products.PatchStatus
{
    internal class UpdateProductStatusCommandHandler : IRequestHandler<UpdateProductStatusCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductStatusCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(UpdateProductStatusCommand command, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository.GetByIdAsync(command.Id);

            if (existingProduct == null)
                throw new NotFoundException($"Product with id {command.Id} not found!");

            existingProduct.Status = command.Status;

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

    }
}