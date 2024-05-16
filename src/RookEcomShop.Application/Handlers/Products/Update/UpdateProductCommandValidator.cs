using FluentValidation;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Name is require");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(500);
            RuleFor(x => x.Price).NotEmpty().GreaterThan(0);
            RuleFor(x => x.StockQuantity).NotEmpty().GreaterThanOrEqualTo(0);
        }
    }
}
