namespace RookEcomShop.CustomerFrontend.Models.Products
{
    public class TotalStar
    {
        public string Label { get; set; } = null!;
        public int TotalStars { get; set; } = 1;
        public int Ammount { get; set; } = 0;
        public double Volume => Math.Round((double)(Ammount * 100) / (TotalStars > 0 ? TotalStars : 1));
    }
}