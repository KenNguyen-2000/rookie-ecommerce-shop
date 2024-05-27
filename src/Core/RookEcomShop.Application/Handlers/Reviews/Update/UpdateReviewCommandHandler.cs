using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.Handlers.Reviews.Update
{
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand, Result>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateReviewCommandHandler(IReviewRepository reviewRepository, IUnitOfWork unitOfWork)
        {
            _reviewRepository = reviewRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var review = await _reviewRepository.GetByIdAsync(request.Id, cancellationToken);

            if (review == null)
            {
                throw new NotFoundException("Review not found");
            }

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