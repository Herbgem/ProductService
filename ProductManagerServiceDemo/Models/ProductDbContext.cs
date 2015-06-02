using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ProductManagerServiceDemo.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
            : base("ServiceConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}