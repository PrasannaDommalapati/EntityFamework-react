using RestApiDev.Library.Data.Entity;
using System.Threading.Tasks;

namespace RestApiDev.Library.Data
{
    public interface IWorkFoundry
    {
        Task AddPromotionAsync(PromotedItem promotedItem);
    }
}
