using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class PurchaseContext : DbContext
    {

        public PurchaseContext (DbContextOptions<PurchaseContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Purchase> Purchase { get; set; }
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
        public DbSet<MvcMovie.Models.Login> Login { get; set; }
    }
}
