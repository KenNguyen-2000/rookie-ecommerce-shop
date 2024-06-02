using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Persistence.Repositories;


namespace RookEcomShop.Application.Handlers.Reviews.Delete
{
    public class DeleteReviewCommandHandler : BaseService, IRequestHandler<DeleteReviewCommand, Result>
    {
        private readonly IReviewRepository _reviewRepository;

        public DeleteReviewCommandHandler(IReviewRepository reviewRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Result> Handle(DeleteReviewCommand request, CancellationToken cancellationToken)
        {
            var review = await _reviewRepository
                                .GetByIdAsync(request.Id, cancellationToken)
                                .ThrowIfNullAsync($"Review with id {request.Id}");


            if (request.UserId != review.UserId)
            {
                throw new ForbiddenException("You are not allowed to delete this review");
            }

            _reviewRepository.Delete(review);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }
    }
}