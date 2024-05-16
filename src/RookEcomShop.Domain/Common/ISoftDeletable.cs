namespace RookEcomShop.Domain.Common
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOnUtc { get; set; }
    }
}
