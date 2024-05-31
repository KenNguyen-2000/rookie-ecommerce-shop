namespace RookEcomShop.Domain.Common
{
    public interface ITrackable
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
