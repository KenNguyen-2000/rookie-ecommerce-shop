using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public string[]? Errors { get; set; }
        public NotFoundException(string message) : base(message)
        {

        }

        public NotFoundException(string[] errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }
    }
}
