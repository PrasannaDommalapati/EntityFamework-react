using RestApiDev.Library.Models;
using System.Threading.Tasks;

namespace RestApiDev.Manager
{
    public interface IStory
    {
        Task<string> CreatePromotion(PromotionModel promotion);
    }
}
