﻿using FluentValidation;

namespace RookEcomShop.Application.Handlers.Products.Create
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Price).NotEmpty().GreaterThan(0);
            RuleFor(x => x.StockQuantity).NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(x => x.CategoryName).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}
