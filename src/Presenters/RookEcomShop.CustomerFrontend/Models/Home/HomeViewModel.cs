using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Models.Home
{
    public class HomeViewModel
    {
        public PaginatedList<ProductDto> ProductDatas { get; set; } = null!;
        public IEnumerable<ProductDto> BestSellers { get; set; } = new List<ProductDto>();
        public IEnumerable<ProductDto> BestReviews { get; set; } = new List<ProductDto>();

        public static HomeViewModel Create(PaginatedList<ProductDto> productDatas, IEnumerable<ProductDto> bestSellers, IEnumerable<ProductDto> bestReviews)
        {
            return new HomeViewModel
            {
                ProductDatas = productDatas,
                BestSellers = bestSellers,
                BestReviews = bestReviews
            };
        }
    }
}