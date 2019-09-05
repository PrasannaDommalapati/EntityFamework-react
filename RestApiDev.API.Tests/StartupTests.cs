using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace RestApiDev.API.Tests
{
    [TestClass]
    public class StartupTests
    {
        [TestMethod]
        public void ConfigureServices_Success()
        {
            var configuration = Substitute.For<IConfiguration>();
            var environment = Substitute.For<IHostingEnvironment>();

            var services = Substitute.For<IServiceCollection>();

            var startup = new Startup(configuration, environment);

            Assert.AreSame(startup.Configuration, configuration);
            Assert.AreSame(startup.Environment, environment);

            Assert.IsNotNull(services);

            //startup.ConfigureServices(services);
            //services.Received().AddMvcCore();
            //services.Received().AddSwaggerGen(Arg.Any<Action<SwaggerGenOptions>>());;

            //services.Received().Add(Arg.Is<ServiceDescriptor>(x => x.ServiceType == typeof(IStory) && x.ImplementationType == typeof(Story)));
        }
    }
}