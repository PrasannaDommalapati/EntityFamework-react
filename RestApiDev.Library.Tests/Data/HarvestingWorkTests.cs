using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using RestApiDev.Library.Data;
using System;

namespace RestApiDev.Library.Tests.Data
{
    [TestClass]
    public class HarvestingWorkTests
    {
        private IDataContext DataContext;
        private IHarvestingWork HarvestingWork;

        [TestInitialize]
        public void Init()
        {
            DataContext = Substitute.For<IDataContext>();
            HarvestingWork = new HarvestingWork(DataContext);
        }
    }
}
