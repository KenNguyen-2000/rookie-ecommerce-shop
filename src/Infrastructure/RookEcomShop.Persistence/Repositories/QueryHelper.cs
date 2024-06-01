using RookEcomShop.Application.Dto;
using RookEcomShop.Domain.Common;
using System.Linq.Expressions;

namespace RookEcomShop.Persistence.Repositories;

public static class QueryHelper<TQuery, TValue>
    where TQuery : QueryDto
    where TValue : BaseEntity<Guid>
{
    public static IQueryable<TValue> SortValues(TQuery queryDto, IQueryable<TValue> products,
                                                 Expression<Func<TValue, object>> sortProperty)
    {
        return queryDto.SortOrder?.ToLower() switch
        {
            "desc" => products.OrderByDescending(sortProperty),
            _ => products
        };
    }

    public static IQueryable<TValue> PaginateValues(TQuery queryDto, IQueryable<TValue> products)
    {
        return products.Skip((queryDto.Page - 1) * queryDto.PageSize)
            .Take(queryDto.PageSize);
    }
}