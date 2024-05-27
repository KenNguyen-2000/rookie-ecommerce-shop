using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.Update
{
    public class UpdateProductCommand : UpdateProductRequest, IRequest<Result>
    {
        public int Id { get; set; }
    }
}
