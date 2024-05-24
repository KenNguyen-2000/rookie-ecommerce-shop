using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommand : UpdateProductRequest, IRequest<Result>
    {
        public int Id { get; set; }
    }
}
