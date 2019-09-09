using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockQueryable.NSubstitute;
using NSubstitute;
using RestApiDev.Library.Data;
using RestApiDev.Library.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDev.Library.Tests.Data
{
    [TestClass]
    public class HarvestingWorkTests
    {
        private IDataContext DataContext;
        private IHarvestingWork HarvestingWork;
        private List<PromotedItem> PromotedItems;

        [TestInitialize]
        public void Init()
        {
            DataContext = Substitute.For<IDataContext>();
            HarvestingWork = new HarvestingWork(DataContext);

            PromotedItems = new List<PromotedItem>();

            var mockPromotedItemsDbSet = PromotedItems.AsQueryable().BuildMockDbSet();

            DataContext.PromotedItems.Returns(mockPromotedItemsDbSet);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_Null_DataContext()
        {
            _ = new HarvestingWork(null);
        }

        [TestMethod]
        public void Ctor_Success()
        {
            _ = new HarvestingWork(DataContext);
        }

        [TestMethod]
        public async Task GetPromotions_Success()
        {
            var item = new PromotedItem
            {
                Name= "Banana"
            };

            PromotedItems.Add(item);

            var result = await HarvestingWork
                .GetPromotions()
                .ConfigureAwait(false);

            Assert.AreEqual(1, result.Count);
        }
    }
}
