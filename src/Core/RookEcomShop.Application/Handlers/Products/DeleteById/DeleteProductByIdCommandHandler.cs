using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Products.DeleteById
{
    public class DeleteProductByIdCommandHandler : BaseService, IRequestHandler<DeleteProductByIdCommand, Result>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductByIdCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _productRepository = productRepository;
        }

        public async Task<Result> Handle(DeleteProductByIdCommand command, CancellationToken cancellationToken)
        {
            var product = await _productRepository
                                    .GetByIdAsync(command.Id)
                                    .ThrowIfNullAsync($"Product with id {command.Id}");

            _productRepository.Delete(product);
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
