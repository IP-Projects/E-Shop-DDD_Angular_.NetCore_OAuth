using Domain.Core.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Database.SQLite
{
    public class SqLiteContextFactory : IDesignTimeDbContextFactory<SqLiteContext>
    {
        public SqLiteContext CreateDbContext(string[] args)
        {
            var config = ConfigurationResolver.GetConfiguration();
            var optionsBuilder = new DbContextOptionsBuilder<SqLiteContext>();
            optionsBuilder.UseSqlite(config.GetConnectionString("SqLite"),
                builder => builder.MigrationsAssembly(typeof(SqLiteContext).Assembly.FullName));
            var context = new SqLiteContext(optionsBuilder.Options);
            return context;
        }
    }
}
