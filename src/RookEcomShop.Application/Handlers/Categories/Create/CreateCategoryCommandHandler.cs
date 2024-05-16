using MediatR;

namespace RookEcomShop.Application.Handlers.Categories.Create
{
    internal class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        public Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
