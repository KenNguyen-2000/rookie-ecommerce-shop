using AutoFixture;
using AutoFixture.AutoMoq;
using Moq;
using RookEcomShop.Application.Common.Repositories;

namespace RookEcomShop.Application.UnitTest
{
    public class TestSetup
    {
        protected readonly Mock<IUnitOfWork> _mockUnitOfWork;
        protected readonly IFixture _fixture;

        public TestSetup()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());

            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            _mockUnitOfWork = new Mock<IUnitOfWork>();
        }

    }
}