using FluentValidation;

namespace RookEcomShop.Application.Handlers.Reviews.Create
{
    public class CreateReviewCommandValidator : AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewCommandValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty();
            RuleFor(x => x.ProductId)
                .NotEmpty();
            RuleFor(x => x.Rating)
                .NotEmpty()
                .InclusiveBetween(1, 5);
            RuleFor(x => x.Content)
                .NotEmpty()
                .MaximumLength(500);
        }
    }
}