using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.ViewModels.Identity
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            var blacklistedWords = new string[] { "password", "123456" };

            RuleFor(x => x.Email)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(10)
                .EmailAddress();

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(2);

            RuleFor(x => x.LastName)
               .NotEmpty()
               .MaximumLength(50)
               .MinimumLength(2);

            RuleFor(x => x.Password)
                           .MinimumLength(8)
                           .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more capital letters.")
                           .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters.")
                           .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits.")
                           .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{ PropertyName}' must contain one or more special characters.")
                           .Matches("^[^£# “”]*$").WithMessage("'{PropertyName}' must not contain the following characters £ # “” or spaces.")
                           .Must(pass => !blacklistedWords.Any(word => pass.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0))
                               .WithMessage("'{PropertyName}' contains a word that is not allowed.");

            RuleFor(x => x.PhoneNumber)
                .MinimumLength(10)
                .MaximumLength(15);

            RuleFor(x => x.Dob)
                .LessThan(DateTime.Now);
        }
    }
}
