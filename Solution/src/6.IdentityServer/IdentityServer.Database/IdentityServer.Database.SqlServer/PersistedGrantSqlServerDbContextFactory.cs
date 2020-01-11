using System.Reflection;
using IdentityServer.Core.Helpers;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IdentityServer.Database.SqlServer
{
    public class PersistedGrantSqlServerDbContextFactory : IDesignTimeDbContextFactory<PersistedGrantDbContext>
    {
        public PersistedGrantDbContext CreateDbContext(string[] args)
        {
            var config = ConfigurationResolver.GetConfiguration();

            var optionsBuilder = new DbContextOptionsBuilder<PersistedGrantDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("SQLServer"),
                sql => sql.MigrationsAssembly(typeof(PersistedGrantSqlServerDbContextFactory).GetTypeInfo().Assembly.GetName().Name));
            return new PersistedGrantDbContext(optionsBuilder.Options, new OperationalStoreOptions());
        }
    }
}
