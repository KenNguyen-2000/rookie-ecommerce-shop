using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Carts;

public class CartsMapper
{
    public static CartDetailDto MapToCartDetailDto(CartDetail cartDetail)
    {
        return new CartDetailDto
        {
            Id = cartDetail.Id,
            Quantity = cartDetail.Quantity,
            Product = new ProductDto
            {
                Id = cartDetail.Product.Id,
                Description = cartDetail.Product.Description,
                Name = cartDetail.Product.Name,
                Price = cartDetail.Product.Price,
                Status = cartDetail.Product.Status,
                Category = new CategoryDto
                {
                    Id = cartDetail.Product.Category.Id,
                    Name = cartDetail.Product.Category.Name,
                    ParentId = cartDetail.Product.Category.CategoryId,
                    Description = cartDetail.Product.Category.Description
                },
                ImgUrls = cartDetail.Product.ProductImages.Select(pI => pI.Url)
            }
        };
    }
}