using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        public DbSet<Customer> Customers { get; set; } // My domain models
        public DbSet<Movie> Movies { get; set; }// My domain models
    }
}