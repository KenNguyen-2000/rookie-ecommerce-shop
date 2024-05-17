using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RookEcomShop.IdentityServer.Pages
{
    public class RedirectModel : PageModel
    {
        public string? RedirectUrl { get; set; }
        public void OnGet()
        {
        }
    }
}
