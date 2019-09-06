using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestApiDev.Library.Data;
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
            Mapper = new Mock<IMapper>().Object;
            DataContext = new Mock<IDataContext>().Object;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_DataContext_Null()
        {
            _ = new Testimony(null,Mapper);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_Mapper_Null()
        {
            _ = new Testimony(DataContext,null);
        }
    }
}
