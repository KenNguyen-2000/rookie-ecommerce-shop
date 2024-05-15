using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Common.Exceptions
{
    public class BadRequestException : Exception
    {
        public string[]? Errors { get; set; }
        public BadRequestException(string message) : base(message)
        {

        }

        public BadRequestException(string[] errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }
    }
}
