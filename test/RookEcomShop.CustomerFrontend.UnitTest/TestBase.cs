using AutoFixture;
using AutoFixture.AutoMoq;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using RookEcomShop.CustomerFrontend.UnitTest.Behaviors;

namespace RookEcomShop.CustomerFrontend.UnitTest
{
    public class TestBase
    {
        // protected readonly HttpClient _client;
        protected readonly IFixture _fixture;
        protected const string fakeBaseAddress = "https://www.example.com";

        public TestBase()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                            .ForEach(b => _fixture.Behaviors.Remove(b));
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior(recursionDepth: 2));
            // _fixture.Behaviors.Add(new RecursionDepthBehavior(2));
            // _client = factory.WithWebHostBuilder(builder =>
            // {
            //     builder.ConfigureServices(services =>
            //     {
            //         // services.AddSingleton(_mediatorMock.Object);
            //         // services.AddSingleton(_userContext);
            //     });
            // }).CreateClient();
        }
    }
}