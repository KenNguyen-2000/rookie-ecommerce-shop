using AutoFixture;
using MediatR;
using Moq;
using RookEcomShop.Api.UnitTest.TestUtils;
using RookEcomShop.Application.Common.Helpers;

namespace RookEcomShop.Api.UnitTest.Controllers;

public class TestControllerSetup
{
    protected readonly Mock<IMediator> _mockSender;
    protected readonly UserContext _mockUserContext;
    protected readonly Fixture _fixture;

    public TestControllerSetup()
    {
        _mockSender = new Mock<IMediator>();
        _mockUserContext = new UserContext();
        _mockUserContext.SetContext(Guid.NewGuid(), "test@gmail.com", "Admin");

        _fixture = new Fixture();

        _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                            .ForEach(b => _fixture.Behaviors.Remove(b));
        _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
    }

}