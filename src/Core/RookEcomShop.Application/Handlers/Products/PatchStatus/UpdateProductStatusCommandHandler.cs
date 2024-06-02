using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Products.PatchStatus
{
    internal class UpdateProductStatusCommandHandler : BaseService, IRequestHandler<UpdateProductStatusCommand, Result>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductStatusCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _productRepository = productRepository;
        }

        public async Task<Result> Handle(UpdateProductStatusCommand command, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository
                                            .GetByIdAsync(command.Id, cancellationToken)
                                            .ThrowIfNullAsync($"Product with id {command.Id}");

            existingProduct.Status = command.Status;

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

    }
}
