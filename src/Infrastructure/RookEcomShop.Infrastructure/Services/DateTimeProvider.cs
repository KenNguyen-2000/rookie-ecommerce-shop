using RookEcomShop.Application.Common.Interfaces.Services;

namespace RookEcomShop.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
