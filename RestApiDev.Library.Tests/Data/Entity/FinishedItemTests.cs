using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.Library.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDev.Library.Tests.Data.Entity
{
    [TestClass]
    public class FinishedItemTests
    {
        [TestMethod]
        public void Ctor_Success()
        {
            var faker = new Faker();
            var finishedDate = DateTime.UtcNow.AddDays(1);
            var id = faker.Random.Guid();
            var name = faker.Name.FullName();
            var result = new FinishedItem
            {
                FinishedDate = finishedDate,
                Name = name,
                Id = id,
                IsComplete = true
            };

            Assert.AreEqual(finishedDate, result.FinishedDate);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(id, result.Id);
            Assert.IsTrue(result.IsComplete);
        }
    }
}
