using Domain.Core.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Database.SqlServer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // the name of one of the classes in the project that hosts the mappings/configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IDbContext).Assembly);
        }
    }
}
