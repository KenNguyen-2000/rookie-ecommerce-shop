using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        [HttpPost]
        public void AddReview(int productId)
        {
            Console.WriteLine("Hello World!" + productId);
        }
    }
}
