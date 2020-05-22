using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genre{ get; set; }

    }
}