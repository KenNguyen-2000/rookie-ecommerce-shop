using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.Handlers.Products.DeleteById
{
    public class DeleteProductByIdCommandHandler : IRequestHandler<DeleteProductByIdCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductByIdCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(DeleteProductByIdCommand command, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(command.Id);
            if (product == null)
                throw new NotFoundException($"Product with id {command.Id} not found");

            _productRepository.Delete(product);
            await _unitOfWork.SaveAsync();

            return Result.Ok();
        }
    }
}
