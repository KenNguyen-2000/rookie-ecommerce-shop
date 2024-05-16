using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQueryHandler : IRequestHandler<GetProductsByCategoryNameQuery, IEnumerable<ProductVM>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsByCategoryNameQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductVM>> Handle(GetProductsByCategoryNameQuery query, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetListAsync(x => x.Category.Name == query.CategoryName);

            return products.Select(p => new ProductVM
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                Category = new CategoryVM
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name
                },
                ImgUrls = p.ProductImages.Select(i => i.Url).ToList()
            });
        }
    }
}
