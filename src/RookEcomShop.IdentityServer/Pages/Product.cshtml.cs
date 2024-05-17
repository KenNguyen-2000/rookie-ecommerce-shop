using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RookEcomShop.IdentityServer.Pages
{
    [AllowAnonymous]
    public class ProductModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
