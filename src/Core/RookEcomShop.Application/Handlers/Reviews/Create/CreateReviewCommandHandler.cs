using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Reviews.Create
{
    public class CreateReviewCommandHandler : BaseService, IRequestHandler<CreateReviewCommand, Result>
    {

        private readonly IReviewRepository _reviewRepository;
        private readonly IProductRepository _productRepository;

        public CreateReviewCommandHandler(
            IReviewRepository reviewRepository,
            IDateTimeProvider dateTimeProvider,
            IUnitOfWork unitOfWork,
            IProductRepository productRepository) : base(unitOfWork)
        {
            _reviewRepository = reviewRepository;
            _productRepository = productRepository;
        }

        public async Task<Result> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository
                                    .GetByIdAsync(request.ProductId, cancellationToken)
                                    .ThrowIfNullAsync($"Product with id {request.ProductId}");

            CreateReview(request, product);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private void CreateReview(CreateReviewCommand request, Product product)
        {
            var review = new Review
            {
                Content = request.Content,
                Rating = request.Rating,
                UserId = request.UserId,
                Product = product
            };

            _reviewRepository.Create(review);
        }
    }
}