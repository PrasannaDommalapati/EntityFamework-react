using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiDev.Library.Models;
using RestApiDev.Manager;
using static RestApiDev.Library.Configuration;

namespace RestApiDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {

        private IStory Promotions { get; }

        public PromotionController(IStory story)
        {
            Promotions = story ?? throw new ArgumentNullException(nameof(story));
        }

        // GET api/promotion
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "promotion1", "promotion2" };
        }

        // GET api/promotions/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "promotion";
        }

        // POST api/promotions
        [HttpPost]
        [Route(PromotionEndpoint)]
        public Task<string> CreatePromotion(
            [FromBody]
            [Bind(nameof(PromotionModel.Id))] PromotionModel promotionModel)
        {
            Console.WriteLine(promotionModel);
            return Promotions.CreatePromotion(promotionModel);
        }

        // PUT api/promotions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string promotion)
        {
        }

        // DELETE api/promotions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
