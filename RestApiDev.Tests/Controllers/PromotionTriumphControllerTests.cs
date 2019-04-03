using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.Controllers;
using System;

namespace RestApiDev.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatePromotion_Returns_Guid()
        {
        }

        [TestMethod]
        public void Ctor_Throws_Null_Story()
        {
            var exception = Assert.ThrowsException<ArgumentNullException>(() =>
                new PromotionController(null));
            Assert.IsNotNull(exception);
        }
    }
}
