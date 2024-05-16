using FluentValidation;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;

namespace RookEcomShop.Application.Common.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse> : 
        IPipelineBehavior<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
        where TResponse : notnull
    {
        private readonly IValidator<TRequest>? _validator;

        public ValidationBehavior(IValidator<TRequest>? validator = null)
        {
            _validator = validator;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validator == null)
            {
                return await next();
            }

            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.IsValid)
            {
                return await next();
            }

            var errors = validationResult.Errors;

            throw new BadRequestException(errors[0].ErrorMessage);

        }
    }
}
