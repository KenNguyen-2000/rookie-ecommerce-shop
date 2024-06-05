using RookEcomShop.Application.Common.Exceptions;
using System.Threading.Tasks;

namespace RookEcomShop.Persistence.Repositories;

public static class RepositoryExtensions
{
    public static T ThrowIfNull<T>(this T? obj, string errorMessage) where T : class
    {
        if (obj == null)
        {
            throw new NotFoundException(errorMessage + " not found!");
        }
        return obj;
    }

    public static async Task<T> ThrowIfNullAsync<T>(this Task<T?> task, string errorMessage) where T : class
    {
        var result = await task;
        if (result == null)
        {
            throw new NotFoundException(errorMessage + " not found!");
        }

        return result;
    }

    public static async Task<T> ThrowIfAlreadyExists<T>(this Task<T?> task, string errorMessage) where T : class
    {
        var result = await task;
        if (result != null)
        {
            throw new BadRequestException(errorMessage + " already exists!");
        }

        return result;
    }
}