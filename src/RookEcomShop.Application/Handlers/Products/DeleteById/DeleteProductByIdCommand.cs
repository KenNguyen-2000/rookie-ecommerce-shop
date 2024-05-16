using MediatR;

namespace RookEcomShop.Application.Handlers.Products.DeleteById
{
    public class DeleteProductByIdCommand : IRequest
    {
        public int Id { get; set; }
    }
}
