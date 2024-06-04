using AutoFixture;
using AutoFixture.AutoMoq;
using Moq;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.UnitTest
{
    public class TestSetup
    {
        protected readonly Mock<IUnitOfWork> _mockUnitOfWork;
        protected readonly Fixture _fixture;

        public TestSetup()
        {
            _fixture = new Fixture();
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            _fixture.Customize(new AutoMoqCustomization { ConfigureMembers = true });
            _mockUnitOfWork = new Mock<IUnitOfWork>();
        }

    }
}