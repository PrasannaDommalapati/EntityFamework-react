using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestApiDev.Library.Models;
using RestApiDev.Models;
using static RestApiDev.Library.Configuration;

namespace RestApiDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private PromotionTriumphContext Context { get; }

        public PromotionController(PromotionTriumphContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET api/promotion
        [HttpGet]
        public IEnumerable<PromotedItems> Get()
        {
            return Context.PromotedItems
                .Where(item => item.IsComplete == true).ToList();
        }

        // GET api/promotions/5
        [HttpGet("{id}")]
        public IEnumerable<PromotedItems> Get(Guid id)
        {
            var promoteditems = from item in Context.PromotedItems
                                where item.Id == id
                                select item;
            return promoteditems;
        }

        // POST api/promotions
        [HttpPost]
        [Route(PromotionEndpoint)]
        public void CreatePromotion(
            [FromBody]
            [Bind(nameof(PromotionModel.Id))] PromotionModel promotionModel)
        {
            var item = new PromotedItems()
            {
                Name = promotionModel.Name,
                Id = promotionModel.Id,
                StartDate = promotionModel.StartDate,
                EndDate = promotionModel.FinishDate,
                IsComplete = promotionModel.IsComplete

            };
            Context.PromotedItems.Add(item);
            Context.SaveChanges();
        }

        // PUT api/promotions/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] PromotionModel promotionModel)
        {
            var updatedItem = new PromotedItems()
            {
                Name = promotionModel.Name,
                Id = id,
                StartDate = promotionModel.StartDate,
                EndDate = promotionModel.FinishDate,
                IsComplete = promotionModel.IsComplete

            };
            Context.PromotedItems.Update(updatedItem);
            Context.SaveChanges();
        }

        // DELETE api/promotions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
