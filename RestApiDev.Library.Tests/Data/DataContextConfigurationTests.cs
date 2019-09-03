using Bogus;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.Library.Data;

namespace RestApiDev.Library.Tests.Data
{
    [TestClass]
    public class DataContextConfigurationTests
    {
        [TestMethod]
        public void Ctor_Success()
        {
            var connectionString = new Faker().Random.Word();

            var result = new DataContextConfiguration
            {
                SQLConnectionString = connectionString
            };

            Assert.AreEqual(connectionString, result.SQLConnectionString);

            result
                .SQLConnectionString
                .Length
                .Should()
                .Equals(connectionString.Length);
        }
    }
}
