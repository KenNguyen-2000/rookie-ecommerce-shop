using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetById
{
    public class GetProductByIdQuery : IRequest<ProductVM>

    {
        public int Id { get; set; }
    }
}
