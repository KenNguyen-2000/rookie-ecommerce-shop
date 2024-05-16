using System.IO;


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

        public async Task SaveFileAsync(Stream mediaBinaryStream, string fileName)
        {
            var filePath = Path.Combine(_fileUploadFolder, fileName);
            using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinaryStream.CopyToAsync(output);
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
