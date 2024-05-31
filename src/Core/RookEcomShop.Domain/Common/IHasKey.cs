namespace RookEcomShop.Domain.Common
{
    public interface IHasKey<T>
    {
        T Id { get; set; }
    }
}
