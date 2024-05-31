using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Contracts.Product;

namespace RookEcomShop.Application.Handlers.Products.Create
{
    public class CreateProductCommand : CreateProductRequest, IRequest<Result>;
}
