using AutoFixture;
using AutoFixture.AutoMoq;
using Microsoft.EntityFrameworkCore;
using Moq;
using RookEcomShop.Persistence.UnitTest.TestUtils;

namespace RookEcomShop.Persistence.UnitTest;

public class TestSetup
{
    protected readonly IFixture _fixture;
    protected readonly RookEcomShopDbContextMock _dbContextMock;
    public TestSetup()
    {
        _fixture = new Fixture().Customize(new AutoMoqCustomization());

        _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                            .ForEach(b => _fixture.Behaviors.Remove(b));
        _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        var options = new DbContextOptionsBuilder<RookEcomShopDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;
        _dbContextMock = new RookEcomShopDbContextMock(options);
    }
}