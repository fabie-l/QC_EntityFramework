using Microsoft.EntityFrameworkCore;
using QC_EntityFramework.Data;
using QC_EntityFramework.Entities;
using SQLitePCL;

namespace QC_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*var db = new SQLDbContext();

            var cases = new cases
            {
                caseid = 100,
                name = "Case 1",
                memo = "This is a test.",
                owner = "Leslie",
                date = DateTime.Now
            };

            db.cases.AddRange(cases);
            db.SaveChanges();*/

            Batteries.Init();

            using (var sqliteContext = new SQLiteDbContext())
            using (var sqlServerContext = new SQLDbContext())
            {
                var casesFromSQLite = sqliteContext.cases.ToList();

                // Save the data to SQL Server
                sqlServerContext.cases.AddRange(casesFromSQLite);
                sqlServerContext.SaveChanges();
            }
        }
    }
}