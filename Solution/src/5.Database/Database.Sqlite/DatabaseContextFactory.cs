using Domain.Core.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Database.SQLite
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("database.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlite(config.GetConnectionString("Development"),
                builder => builder.MigrationsAssembly(typeof(IDbContext).Assembly.FullName));
            var context = new DatabaseContext(optionsBuilder.Options);
            return context;
        }
    }
}
