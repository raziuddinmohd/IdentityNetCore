using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IdentityNetCore.Data
{
    // Design-time factory for EF tools. Provides the SQL Server provider and connection string during migrations.
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            // Use the same connection string as appsettings.json
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=IdentityDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
