using Microsoft.EntityFrameworkCore;
using RestApiDev.Library.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDev.Library.Data
{
    public class HarvestingWork : UnitOfWork, IHarvestingWork
    {
        public HarvestingWork(IDataContext dataContext) : base(dataContext)
        {
        }

        public Task<List<PromotedItems>> GetPromotions()
        {
            var promotedItems = from p in DataContext.PromotedItems
                                select p;

            return promotedItems
                .ToListAsync();
        }
    }
}
