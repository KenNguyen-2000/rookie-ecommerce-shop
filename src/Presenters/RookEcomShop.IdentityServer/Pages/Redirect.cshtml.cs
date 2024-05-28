using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RookEcomShop.IdentityServer.Views
{
    public class RedirectModel : PageModel
    {
        public string? RedirectUrl { get; set; }
        public void OnGet()
        {
        }
    }
}
