using Microsoft.EntityFrameworkCore;

namespace RookEcomShop.Persistence.UnitTest.TestUtils;

public class RookEcomShopDbContextMock : RookEcomShopDbContext
{
    public RookEcomShopDbContextMock(DbContextOptions<RookEcomShopDbContext> options)
        : base(options)
    {
    }

    public DbSet<ConcreteBaseEntity> ConcreteEntities { get; set; }
}