using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Interfaces.Services;

namespace RookEcomShop.Persistence.Repositories;

public static class RepositoryExtensions
{
    public static T ThrowIfNull<T>(this T obj, string paramName) where T : class
    {
        if (obj == null)
            throw new NotFoundException($"{paramName} not found!");

        return obj;
    }
}