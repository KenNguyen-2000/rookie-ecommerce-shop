using FluentResults;

namespace RookEcomShop.Application.Common.Exceptions
{
    public class BadRequestException : Exception
    {
        public List<IError> Errors { get; set; } = new();
        public BadRequestException(string message) : base(message)
        {

        }

        public BadRequestException(List<IError> errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }
    }
}
