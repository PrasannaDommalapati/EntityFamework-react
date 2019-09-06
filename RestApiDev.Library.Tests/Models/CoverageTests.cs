using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDev.Library.Tests.Models
{
    [TestClass]
    public class CoverageTests
    {
        [TestMethod]
        public void Ctor_Success()
        {
            var faker = new Faker();

            var name = faker.Name.FullName();
            var email = faker.Internet.Email();

            var cov = new Coverage
            {
                Email = email,
                Name = name
            };

            Assert.AreEqual(email, cov.Email);
            Assert.AreEqual(name, cov.Name);
        }
    }
}
