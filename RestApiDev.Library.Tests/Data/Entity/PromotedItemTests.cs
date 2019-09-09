using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.Library.Data.Entity;
using System;

namespace RestApiDev.Library.Tests.Data.Entity
{
    [TestClass]
    public class PromotedItemTests
    {
        [TestMethod]
        public void Ctor_Success()
        {
            var faker = new Faker();
            var startDate = DateTime.UtcNow;
            var endDate = DateTime.UtcNow.AddDays(1);
            var id = faker.Random.Guid();
            var name = faker.Name.FullName();

            var result = new PromotedItem
            {
                EndDate = endDate,
                StartDate = startDate,
                Id = id,
                IsComplete = true,
                Name = name
            };

            Assert.AreEqual(startDate, result.StartDate);
            Assert.AreEqual(endDate, result.EndDate);
            Assert.AreEqual(id, result.Id);
            Assert.IsTrue(result.IsComplete);
            Assert.AreEqual(name, result.Name);
        }
    }
}
