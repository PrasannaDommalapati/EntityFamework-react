using RestApiDev.Library.Models;
using System;
using System.Threading.Tasks;

namespace RestApiDev.Manager
{
    public class Promotion : IPromotion
    {

        public Task<string> CreatePromotion(PromotionModel promotion)
        {
            Console.WriteLine(promotion);

            throw new NotImplementedException();
        }
    }
}
