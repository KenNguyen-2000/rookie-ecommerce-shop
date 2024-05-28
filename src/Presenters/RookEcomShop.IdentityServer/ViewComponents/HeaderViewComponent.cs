using Microsoft.AspNetCore.Mvc;

namespace RookEcomShop.IdentityServer.ViewComponents
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}