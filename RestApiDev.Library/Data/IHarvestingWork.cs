using RestApiDev.Library.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiDev.Library.Data
{
    public interface IHarvestingWork
    {
        Task<List<PromotedItems>> GetPromotions();
    }
}
