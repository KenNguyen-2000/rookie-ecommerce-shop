using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.Create
{
    public class CreateProductCommand : CreateProductRequest, IRequest
    {
    }
}
