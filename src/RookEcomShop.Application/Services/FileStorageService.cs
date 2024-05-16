using Microsoft.AspNetCore.Http;


namespace RookEcomShop.Application.Services
{
    public class FileStorageService : IFileStorageService
    {
        private readonly string _fileUploadFolder;
        private const string IMAGES_FOLDER_NAME = "uploads";

        //public FileStorageService(IWebHostEnvironment webHostEnvironment)
        //{
        //    _fileUploadFolder = Path.Combine(webHostEnvironment.WebRootPath, IMAGES_FOLDER_NAME);
        //}

        public string GetFileUrl(string fileName)
        {
            return $"/{IMAGES_FOLDER_NAME}/{fileName}";
        }

        public async Task<string> SaveFileAsync(IFormFile image)
        {
            // Generate a unique filename
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);

            // Save the image to a storage location (replace with your storage provider)
            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }
            var filePath = Path.Combine(uploads, fileName);
            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            // Return the relative path to the saved image
            return Path.Combine("/uploads", fileName); // Assuming uploads folder is accessible publicly
        }

        public async Task DeleteFileAsync(string fileName)
        {

            var filePath = Path.Combine(_fileUploadFolder, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }
    }
}
