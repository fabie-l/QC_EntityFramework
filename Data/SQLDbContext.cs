using Microsoft.EntityFrameworkCore;
using QC_EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_EntityFramework.Data
{
    public class SQLDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HP-FABIE\SQLEXPRESS;Database=QualCoCo_v1;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<cases> cases { get; set; }
    }
}
