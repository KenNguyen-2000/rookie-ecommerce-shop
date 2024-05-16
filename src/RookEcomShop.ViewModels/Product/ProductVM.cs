﻿using RookEcomShop.ViewModels.Category;

namespace RookEcomShop.ViewModels.Product
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public CategoryVM Category { get; set; } = null!;
        public IEnumerable<string> ImgUrls { get; set; } = new List<string>();
    }
}
