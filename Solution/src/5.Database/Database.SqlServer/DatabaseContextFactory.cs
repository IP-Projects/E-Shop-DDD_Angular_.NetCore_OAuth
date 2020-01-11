using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Database.SqlServer
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("database.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("Production"),
                builder => builder.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName));
            var context = new DatabaseContext(optionsBuilder.Options);
            return context;
        }
    }
}
