using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Application.Dto;

public class ProductQueryDto : QueryDto
{
    public string? CategoryName { get; set; }
    public ProductStatus? Status { get; set; }
    public override int PageSize { get => 20; set => base.PageSize = value; }

}