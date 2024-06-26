﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
namespace RookEcomShop.Application.Services
{
    public class FileStorageService : IFileStorageService
    {
        private readonly string _fileContentFoler;
        private const string FILES_FOLDER_NAME = "uploads";

        public FileStorageService(IHostingEnvironment hostingEnvironment)
        {
            _fileContentFoler = Path.Combine(hostingEnvironment.WebRootPath, FILES_FOLDER_NAME);
        }

        public string GetFileUrl(string fileName)
        {
            return $"/{FILES_FOLDER_NAME}/{fileName}";
        }

        public async Task<string> SaveFileAsync(IFormFile image)
        {
            // Generate a unique filename
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);

            // Save the image to a storage location (replace with your storage provider)
            if (!Directory.Exists(_fileContentFoler))
            {
                Directory.CreateDirectory(_fileContentFoler);
            }
            var filePath = Path.Combine(_fileContentFoler, fileName);
            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            // Return the relative path to the saved image
            return fileName; // Assuming uploads folder is accessible publicly

        }

        public async Task DeleteFileAsync(string fileName)
        {

            var filePath = Path.Combine(_fileContentFoler, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }
    }

}
