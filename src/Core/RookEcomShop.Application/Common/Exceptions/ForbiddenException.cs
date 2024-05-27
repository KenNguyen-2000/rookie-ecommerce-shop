using FluentResults;

namespace RookEcomShop.Application.Common.Exceptions
{
    public class ForbiddenException : Exception
    {
        public List<IError> Errors { get; set; } = new();
        public ForbiddenException(string message) : base(message)
        {

        }

        public ForbiddenException(List<IError> errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }
    }
}
