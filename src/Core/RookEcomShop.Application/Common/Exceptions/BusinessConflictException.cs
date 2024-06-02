using FluentResults;

namespace RookEcomShop.Application.Common.Exceptions
{
    public class BusinessConflictException : Exception
    {
        public List<IError> Errors { get; set; } = new();
        public BusinessConflictException(string message) : base(message)
        {

        }

        public BusinessConflictException(List<IError> errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }
    }
}
