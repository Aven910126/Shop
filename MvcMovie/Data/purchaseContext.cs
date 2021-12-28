using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class purchaseContext : DbContext
    {
        public purchaseContext (DbContextOptions<purchaseContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Purchase> purchase { get; set; }
    }
}
