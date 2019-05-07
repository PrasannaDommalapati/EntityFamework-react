using RestApiDev.Library.Models;
using System.Threading.Tasks;

namespace RestApiDev.Manager
{
    public interface IPromotion 
    {
        Task<string> CreatePromotion(PromotionModel promotion);
    }
}
