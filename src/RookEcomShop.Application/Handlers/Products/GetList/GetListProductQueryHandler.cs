using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, IEnumerable<ProductVM>>
    {
        private readonly IProductRepository _productRepository;

        public GetListProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductVM>> Handle(GetListProductQuery query, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetListAsync(x => x.Name.Contains(query.SearchTerm ?? "")
                                                                     || x.Description.Contains(query.SearchTerm ?? ""));

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
