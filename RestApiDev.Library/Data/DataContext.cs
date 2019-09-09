using Microsoft.EntityFrameworkCore;
using RestApiDev.Library.Data.Entity;

namespace RestApiDev.Library.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DataContext()
        {
        }

        public DbSet<PromotedItem> PromotedItems { get; set; }

        public DbSet<FinishedItems> FinishedItems { get; set; }
    }
}