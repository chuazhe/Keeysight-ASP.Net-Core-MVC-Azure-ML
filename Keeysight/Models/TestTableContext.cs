using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//do all the communications with the database. 
namespace Keeysight.Models
{
    public class TestTableContext: DbContext
    {

        public TestTableContext(DbContextOptions<TestTableContext> options) : base(options)
        { }

        public DbSet<TestTable> TestTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:keeysight.database.windows.net,1433;Initial Catalog=KeeysightIdentity;Persist Security Info=False;User ID=keeysightadmin;Password=Keeysight123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}
