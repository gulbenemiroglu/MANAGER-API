using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=LAPTOP-2MNMTEVQ;database=ManagerAppDb;trusted_connection=true");
        }


        public DbSet<ReaTask> ReaTasks { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
