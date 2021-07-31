using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Session01.BeginingEFCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.BeginingEFCore5.DataAccess
{

    public class BeginingEfCore5Context : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = BeginingEfCore5Db; Integrated Security = True;");
            
            //optionsBuilder.UseSqlServer("Server =.; Database = BeginingEfCore5Db; Integrated Security = True;")
            //    .LogTo(Console.WriteLine,LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
