using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Reviews.Create
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand, Result>
    {

        private readonly IReviewRepository _reviewRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUserRepository _userRepository;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IUnitOfWork _unitOfWork;

        public CreateReviewCommandHandler(
            IReviewRepository reviewRepository,
            IDateTimeProvider dateTimeProvider,
            IUnitOfWork unitOfWork,
            IUserRepository userRepository,
            IProductRepository productRepository)
        {
            _reviewRepository = reviewRepository;
            _dateTimeProvider = dateTimeProvider;
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _productRepository = productRepository;
        }

        public async Task<Result> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            (User, Product) t = await ValidateRequest(request);

            var review = new Review
            {
                Content = request.Content,
                Rating = request.Rating,
                CreatedAt = _dateTimeProvider.UtcNow,
                UpdatedAt = _dateTimeProvider.UtcNow,
                User = t.Item1,
                Product = t.Item2
            };

            _reviewRepository.Create(review);
            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async Task<(User, Product)> ValidateRequest(CreateReviewCommand request)
        {
            var user = await _userRepository.GetUserByIdAsync(request.UserId);
            if (user == null)
                throw new NotFoundException("User not found");

            var product = await _productRepository.GetByIdAsync(request.ProductId);
            if (product == null)
                throw new NotFoundException("Product not found");

            return (user, product);
        }
    }
}