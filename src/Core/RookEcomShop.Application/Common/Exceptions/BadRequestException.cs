using FluentResults;

namespace RookEcomShop.Application.Common.Exceptions
{
    public class BadRequestException : Exception
    {
        public IEnumerable<string> Errors { get; set; } = new List<string>();
        public BadRequestException(string message) : base(message)
        {

        }

        public BadRequestException(IEnumerable<string> errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }
    }
}
