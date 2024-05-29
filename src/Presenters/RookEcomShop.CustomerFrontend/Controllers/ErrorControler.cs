using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace RookEcomShop.CustomerFrontend.Controllers
{

    public class ErrorControler : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found.";
                    // Optionally log the path that caused the 404 error
                    // var originalPath = statusCodeResult.OriginalPath;
                    return View("NotFound");
                // Handle other status codes as needed
                default:
                    ViewBag.ErrorMessage = "An unexpected error occurred.";
                    return View("Error");
            }
        }
    }
}
