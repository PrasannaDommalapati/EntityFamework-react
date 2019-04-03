using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NSubstitute;
using RestApiDev.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDev.Tests
{
    [TestClass]
    public class StartupTests
    {
        private IServiceCollection ServiceCollection;

        [TestMethod]
        public void ConfigureServices_Should_Inject_Story()
        {
            var service = new ServiceCollection();
            service.AddTransient<IStory, Story>();
            var serviceProvider = service.BuildServiceProvider();
            var controller = serviceProvider.GetService<IServiceCollection>();
            Assert.IsNotNull(controller);

            var webHostBuilder = new WebHostBuilder()
                .UseEnvironment("Test")
                .UseStartup<Startup>();
        }

        [TestMethod]
        public void MyTestMethod()
        {
            //arrange
            var serviceCollection = new Mock<IServiceCollection>();
            serviceCollection.Setup(s => s.AddSingleton<IStory, Story>());

            Assert.IsNotNull(serviceCollection);
        }
    }
}
