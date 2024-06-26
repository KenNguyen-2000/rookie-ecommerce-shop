﻿using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Contracts.Product;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommand : UpdateProductRequest, IRequest<Result>
    {
        public Guid Id { get; set; }
    }
}
