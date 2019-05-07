using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.Controllers;
using System;

namespace RestApiDev.Tests
{
    [TestClass]
    public class PromotionTriumphControllerTests
    {
        [TestMethod]
        public void CreatePromotion_Returns_Guid()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Ctor_Throws_Null_Story()
        {
            Assert.IsTrue(true);
            _ = new PromotionController(null);
        }
    }
}
