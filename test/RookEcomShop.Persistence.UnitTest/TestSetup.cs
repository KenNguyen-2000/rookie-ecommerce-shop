using AutoFixture;
using AutoFixture.AutoMoq;
using Microsoft.EntityFrameworkCore;
using Moq;
using RookEcomShop.Persistence.UnitTest.TestUtils;

namespace RookEcomShop.Persistence.UnitTest;

public class TestSetup
{
    protected readonly Fixture _fixture;
    protected readonly RookEcomShopDbContextMock _dbContextMock;
    public TestSetup()
    {
        _fixture = new Fixture();
        // _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        // _fixture.Customize(new AutoMoqCustomization { ConfigureMembers = true });

        var options = new DbContextOptionsBuilder<RookEcomShopDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;
        _dbContextMock = new RookEcomShopDbContextMock(options);
    }
}