using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATDataFetchService.Models;

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
    }
}
