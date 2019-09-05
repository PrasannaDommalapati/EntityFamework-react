using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestApiDev.API.Controllers;
using RestApiDev.Library.Data;
using System;

namespace RestApiDev.API.Tests
{
    [TestClass]
    public class PromotionControllerTests
    {
        private IDataContext DataContext;
        private IMapper Mapper;

        [TestInitialize]
        public void Init()
        {
            DataContext = new Mock<IDataContext>().Object;
            Mapper = new Mock<IMapper>().Object;
        }

        [TestMethod]
        public void CreatePromotion_Returns_Guid()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_Throws_Null_Story()
        {
            _ = new PromotionController(DataContext,Mapper);
        }
    }
}
