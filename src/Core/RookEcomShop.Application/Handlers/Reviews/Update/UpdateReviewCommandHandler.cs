using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Persistence.Repositories;

namespace RookEcomShop.Application.Handlers.Reviews.Update
{
    public class UpdateReviewCommandHandler : BaseService, IRequestHandler<UpdateReviewCommand, Result>
    {
        private readonly IReviewRepository _reviewRepository;

        public UpdateReviewCommandHandler(IReviewRepository reviewRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Result> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var review = await _reviewRepository
                                    .GetByIdAsync(request.Id, cancellationToken)
                                    .ThrowIfNullAsync($"Review with id {request.Id}");

            if (review.UserId != request.UserId)
            {
                throw new ForbiddenException("You are not allowed to update this review");
            }

            review.Rating = request.Rating;
            review.Content = request.Content;

            _reviewRepository.Update(review);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}