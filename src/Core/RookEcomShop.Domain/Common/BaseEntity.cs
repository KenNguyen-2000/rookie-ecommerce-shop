
namespace RookEcomShop.Domain.Common
{
    public abstract class BaseEntity<T> : IHasKey<T>, ITrackable
    {
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
