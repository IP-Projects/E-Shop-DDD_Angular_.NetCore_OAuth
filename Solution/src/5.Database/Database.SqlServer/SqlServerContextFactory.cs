using Domain.Core.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Database.SqlServer
{
    public class SqlServerContextFactory : IDesignTimeDbContextFactory<SqlServerContext>
    {
        public SqlServerContext CreateDbContext(string[] args)
        {
            var config = ConfigurationResolver.GetConfiguration();
            var optionsBuilder = new DbContextOptionsBuilder<SqlServerContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("SQLServer"),
                builder => builder.MigrationsAssembly(typeof(SqlServerContext).Assembly.FullName));
            var context = new SqlServerContext(optionsBuilder.Options);
            return context;
        }
    }
}
