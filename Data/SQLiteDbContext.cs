using Microsoft.EntityFrameworkCore;
using QC_EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_EntityFramework.Data
{
    public class SQLiteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@$"Data Source=copy/data.qda;");
        }

        public DbSet<cases> cases { get; set; }
    }
}
