using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.ViewModels.Cart
{
    public class CartDetailVM : ProductVM
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}
