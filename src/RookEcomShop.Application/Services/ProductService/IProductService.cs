using RookEcomShop.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Services.ProductService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductVM>> GetProductsAsync(string? searchTerm);
        Task CreateProductAsync(CreateProductRequest product);
        Task<ProductVM> GetProductByIdAsync(int id);
    }
}
