using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDev.Models
{
    public class PromotionTriumphContext : DbContext
    {
        public PromotionTriumphContext(DbContextOptions<PromotionTriumphContext> options) : base(options)
        {

        }

        public DbSet<PromotedItems> PromotedItems { get; set; }

        public DbSet<FinishedItems> FinishedItems { get; set; }
    }
}
