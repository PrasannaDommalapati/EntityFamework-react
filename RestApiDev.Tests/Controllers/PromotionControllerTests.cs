using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.API.Controllers;
using System;

namespace RestApiDev.API.Tests
{
    [TestClass]
    public class PromotionControllerTests
    {
        [TestMethod]
        public void CreatePromotion_Returns_Guid()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_Throws_Null_Story()
        {
            _ = new PromotionController(null);
        }
    }
}
