using ECommerceEF.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceEF.Data
{
    public class ProductDbContext : DbContext
    {
        const string Connectionstring= "Server=.;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connectionstring);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplyer> Supplyers { get; set; }
    }
}
