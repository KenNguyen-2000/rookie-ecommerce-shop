using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(
            IProductRepository productRepository,
            IUnitOfWork unitOfWork,
            ICategoryRepository categoryRepository,
            IUserRepository userRepository)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
        }

        public async Task CreateProductAsync(CreateProductRequest product)
        {
            var category = await _categoryRepository.GetByIdAsync(product.CategoryId);

            if (category == null)
            {
                throw new Exception("Category not found");
            }

            var user =  await _userRepository.GetUserByIdAsync(product.UserId);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            var newProduct = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.Stock,
                User = user,
                Category = category
            };
            _productRepository.Create(newProduct);
            await _unitOfWork.SaveAsync();

        }

        public async Task<ProductVM> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if(product == null)
            {
                throw new Exception("Product not found");
            }
            return new ProductVM
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity
            };
        }

        public async Task<IEnumerable<ProductVM>> GetProductsAsync(string? searchTerm)
        {
            var products = await _productRepository.GetListAsync(x => x.Name.Contains(searchTerm ?? "") || x.Description.Contains(searchTerm ?? ""));

            return products.Select(p => new ProductVM
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                
            });
        }


    }
}
