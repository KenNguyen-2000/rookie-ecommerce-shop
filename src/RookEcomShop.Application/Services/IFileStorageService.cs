using Microsoft.AspNetCore.Http;

namespace RookEcomShop.Application.Services
{
    public interface IFileStorageService
    {
        string GetFileUrl(string fileName);

        Task<string> SaveFileAsync(IFormFile file);

        Task DeleteFileAsync(string fileName);
    }
}
