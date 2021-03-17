using System.Data.Entity;
using SugarLevelTracker.Models;

namespace SugarLevelTracker.Data
{
    // DbContext refers to the connection string
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
            base("OktaConnectionString")
        { 
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // This will map to a table in the database
        public DbSet<SugarLevel> SugarLevels { get; set; }
    }
}