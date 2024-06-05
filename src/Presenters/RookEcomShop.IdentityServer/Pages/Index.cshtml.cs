using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RookEcomShop.IdentityServer.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
           return  Redirect("https://localhost:7019/");
        }
    }
}
