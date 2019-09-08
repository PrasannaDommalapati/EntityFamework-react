using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using RestApiDev.Library.Data;
using RestApiDev.Library.Models;
using System;

namespace RestApiDev.Manager.Tests
{
    [TestClass]
    public class TestimonyTests
    {
        private IMapper Mapper;
        private IDataContext DataContext;

        [TestInitialize]
        public void Init()
        {
            Mapper = Substitute.For<IMapper>();
            DataContext = Substitute.For<IDataContext>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_DataContext_Null()
        {
            _ = new Testimony(null, Mapper);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_Mapper_Null()
        {
            _ = new Testimony(DataContext, null);
        }

        [TestMethod]
        public void Create_Null_PromotionModel()
        {
            var testimony = new Testimony(DataContext, Mapper);

            Assert.ThrowsException<ArgumentNullException>(() => testimony.Create(null));
        }

        [TestMethod]
        public void Create_Success()
        {
            var promotionModel = new PromotionModel();
            var testimony = new Testimony(DataContext, Mapper);
            
            testimony.Create(promotionModel);

            DataContext
                .Received()
                .Update();
        }
    }
}
