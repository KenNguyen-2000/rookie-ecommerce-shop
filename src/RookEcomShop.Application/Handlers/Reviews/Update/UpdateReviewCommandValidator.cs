using FluentValidation;

namespace RookEcomShop.Application.Handlers.Reviews.Update
{
    public class UpdateReviewCommandValidator : AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty();
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