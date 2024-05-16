using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/upload-image")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetImage(string imageName)
        {
            // Validate and sanitize imageName (security precaution)
            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            var imagePath = Path.Combine(uploads, imageName);

            if (System.IO.File.Exists(imagePath))
            {
                var imageBytes = System.IO.File.ReadAllBytes(imagePath);
                return File(imageBytes, "image/jpeg", imageName); // Set content type and filename
            }
            else
            {
                return NotFound();
            }
        }

    }
}
