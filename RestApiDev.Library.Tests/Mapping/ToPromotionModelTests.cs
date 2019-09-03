using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiDev.Library.Data.Entity;
using RestApiDev.Library.Mapping;
using RestApiDev.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDev.Library.Tests.Mapping
{
    [TestClass]
    public class ToPromotionModelTests
    {
        [TestMethod]
        public void PromotedItems_To_PromotionModel()
        {
            IMapper mapper = AutoMappingRegister.Create();

            var promotionItem = new PromotedItems
            {
                EndDate = DateTime.Now.AddDays(10),
                StartDate = DateTime.Now,
                IsComplete = false,
                Name = "banana"
            };

            var model = mapper.Map<PromotionModel>(promotionItem);

            Assert.AreEqual(promotionItem.EndDate, model.FinishDate);
        }
    }
}
