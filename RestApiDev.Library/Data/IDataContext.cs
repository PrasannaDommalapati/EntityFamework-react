using Microsoft.EntityFrameworkCore;
using RestApiDev.Library.Data.Entity;
using System;
using System.Threading.Tasks;

namespace RestApiDev.Library.Data
{
    public interface IDataContext : IDisposable
    {

        void CreatePromotion(PromotedItems promotedItem);

        DbSet<PromotedItems> PromotedItems { get; set; }

        DbSet<FinishedItems> TrackingRequests { get; set; }

        void Update();

        Task UpdateAsync();
    }
}
