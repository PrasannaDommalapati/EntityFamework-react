using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using RestApiDev.Library.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDev.Library.Tests.Data
{
    [TestClass]
    public class WorkFoundryTests
    {
        private IDataContext DataContext;
        private IWorkFoundry WorkFoundry;

        [TestInitialize]
        public void Init()
        {
            DataContext = Substitute.For<IDataContext>();
            WorkFoundry = new WorkFoundry(DataContext);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_Null()
        {
            _ = new WorkFoundry(null);
        }

        [TestMethod]
        public void Ctor_Success()
        {
            _ = new WorkFoundry(DataContext);
        }

        [TestMethod]
        public async Task AddPromotionAsync_Null_PromotedItem()
        {
            await Assert
                .ThrowsExceptionAsync<ArgumentNullException>(() => WorkFoundry.AddPromotionAsync(null))
                .ConfigureAwait(false);
        }
    }
}
