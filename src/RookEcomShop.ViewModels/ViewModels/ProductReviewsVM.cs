using RookEcomShop.ViewModels.Contracts.Reviews;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.ViewModels.ViewModels;

public class ProductReviewsVM
{
    public ProductDto Product { get; set; } = null!;
    public ReviewsProductInputModel ReviewsProductInputModel { get; set; } = new ReviewsProductInputModel();
    public PaginatedList<ReviewDto> Reviews { get; set; } = new PaginatedList<ReviewDto>();
    public double AverageRating => Reviews.Items.Any() ? Math.Round(Reviews.Items.Average(x => x.Rating), 1) : 0;
    public int GetRatingCount(int rating) => Reviews.Items.Count(x => x.Rating == rating);
    public RemoveReviewVM RemoveReviewVM { get; set; } = new RemoveReviewVM();

    public int TotalFiveStar => GetRatingCount(5);
    public int TotalFourStar => GetRatingCount(4);
    public int TotalThreeStar => GetRatingCount(3);
    public int TotalTwoStar => GetRatingCount(2);
    public int TotalOneStar => GetRatingCount(1);
}

public class TotalStar
{
    public string Label { get; set; } = null!;
    public int TotalStars { get; set; } = 1;
    public int Ammount { get; set; } = 0;
    public double Volume => Math.Round((double)(Ammount * 100) / (TotalStars > 0 ? TotalStars : 1));
}