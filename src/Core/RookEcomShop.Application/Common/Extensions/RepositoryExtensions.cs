using RookEcomShop.Application.Common.Exceptions;

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

    public static T ThrowIfAlreadyExists<T>(this T? obj, string errorMessage) where T : class
    {
        if (obj != null)
        {
            throw new BadRequestException(errorMessage + " already exists!");
        }

        return obj;
    }
}