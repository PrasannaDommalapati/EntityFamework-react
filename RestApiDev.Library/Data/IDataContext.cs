using Microsoft.EntityFrameworkCore;
using RestApiDev.Library.Data.Entity;
using System;
using System.Threading.Tasks;

namespace RestApiDev.Library.Data
{
    public interface IDataContext : IDisposable
    {

        void CreatePromotion(PromotedItem promotedItem);

        DbSet<PromotedItem> PromotedItems { get; set; }

        DbSet<FinishedItem> TrackingRequests { get; set; }

        void Update();

        Task UpdateAsync();
    }
}
