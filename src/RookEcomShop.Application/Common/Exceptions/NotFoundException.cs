﻿using FluentResults;

namespace RookEcomShop.Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public List<IError> Errors { get; set; }
        public NotFoundException(string message) : base(message)
        {

        }

        public NotFoundException(List<IError> errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }
    }
}
