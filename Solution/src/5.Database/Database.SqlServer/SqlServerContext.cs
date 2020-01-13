using Domain.Core.Base;
using Microsoft.EntityFrameworkCore;

namespace Database.SqlServer
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions options) : base(options)
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
