using RestApiDev.Library.Data.Entity;
using System;
using System.Threading.Tasks;

namespace RestApiDev.Library.Data
{
    public class WorkFoundry : UnitOfWork, IWorkFoundry
    {
        public WorkFoundry(IDataContext dataContext) : base(dataContext) { }

        public Task AddPromotionAsync(PromotedItem promotedItem)
        {
            promotedItem.ValidateForNotNull();

            return default;
        }
    }
}
