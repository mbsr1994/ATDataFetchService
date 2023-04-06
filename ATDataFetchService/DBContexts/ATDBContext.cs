using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATDataFetchService.Models;
using System.Data.Entity.Infrastructure;

namespace ATDataFetchService.DBContexts
{
    public class ATDBContext: DbContext
    {
        public ATDBContext()
        {
        }


        public ATDBContext(DbContextOptions<ATDBContext> options)
            : base(options)
        {
        }

        public DbSet<ATDataFetchService.Models.ATOrderDetailsOutput> ATOrderDetailsOutput { get; set; }
        public DbSet<ATDataFetchService.Models.ATRouteOrderPercentage> ATRouteOrderPercentage { get; set; }
        public DbSet<ATDataFetchService.Models.ATCustomerOrderPercentage> ATCustomerOrderPercentage { get; set; }
    }
}
