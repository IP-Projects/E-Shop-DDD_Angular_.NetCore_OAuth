using System.Reflection;
using IdentityServer.Core.Helpers;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IdentityServer.Database.SQLite
{
    public class PersistedGrantSqLiteDbContextFactory : IDesignTimeDbContextFactory<PersistedGrantDbContext>
    {
        public PersistedGrantDbContext CreateDbContext(string[] args)
        {
            var config = ConfigurationResolver.GetConfiguration();
            var optionsBuilder = new DbContextOptionsBuilder<PersistedGrantDbContext>();
            optionsBuilder.UseSqlite(config.GetConnectionString("SQLite"),
                sql => sql.MigrationsAssembly(typeof(PersistedGrantSqLiteDbContextFactory).GetTypeInfo().Assembly.GetName().Name));
            return new PersistedGrantDbContext(optionsBuilder.Options, new OperationalStoreOptions());
        }
    }
}
