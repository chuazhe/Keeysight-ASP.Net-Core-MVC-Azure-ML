using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//do all the communications with the database. 
namespace Keeysight.Models
{
    public class TestTableContext : DbContext
    {

        public TestTableContext(DbContextOptions<TestTableContext> options) : base(options)
        { }

        public DbSet<TestTable> TestTable { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        /*
        Configuration Conventions
A Configuration Convention is a way to configure entities without overriding the default behavior provided in the Fluent API.
You can define a configuration convention in the OnModelCreating() method and also in a custom class
, similar to how you would define normal entity mappings with Fluent API.
             */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
