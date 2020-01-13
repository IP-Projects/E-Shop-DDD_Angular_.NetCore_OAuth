using Microsoft.EntityFrameworkCore;

namespace Database.SQLite
{
    public class SqLiteContext : DbContext
    {
        public SqLiteContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // the name of one of the classes in the project that hosts the mappings/configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqLiteContext).Assembly);
        }
    }
}
