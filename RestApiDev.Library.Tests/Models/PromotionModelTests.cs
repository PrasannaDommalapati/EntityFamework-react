using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RestApiDev.Library.Models.Tests
{
    [TestClass]
    public class PromotionModelTests
    {
        [TestMethod]
        public void Ctor_Success()
        {
            var date = DateTime.UtcNow;
            var name = "Initial Promotion";
            var referenceId = Guid.NewGuid();
            var promotionModel = new PromotionModel
            {
                Id = referenceId,
                Name = name,
                IsComplete= false,
                StartDate = date,
                FinishDate = date.AddDays(3)
            };

            Assert.AreEqual(promotionModel.Id, referenceId);
            Assert.AreEqual(promotionModel.Name, name);
            Assert.AreEqual(promotionModel.IsComplete, false);
            Assert.AreEqual(promotionModel.StartDate, date);
            Assert.AreEqual(promotionModel.FinishDate, date.AddDays(3));
        }
    }
}
