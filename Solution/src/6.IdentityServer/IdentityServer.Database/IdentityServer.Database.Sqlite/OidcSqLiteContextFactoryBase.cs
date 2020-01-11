using IdentityServer.Core.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IdentityServer.Database.SqLite
{
    public abstract class OidcSqLiteContextFactoryBase<TContext> : IDesignTimeDbContextFactory<TContext>
    where TContext: DbContext
    {
        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);

        public TContext CreateDbContext(string[] args)
        {
            var config = ConfigurationResolver.GetConfiguration();
            var optionsBuilder = new DbContextOptionsBuilder<TContext>();
            optionsBuilder.UseSqlite(config.GetConnectionString("SqLite"),
                builder => builder.MigrationsAssembly(typeof(TContext).Assembly.FullName));
            return CreateNewInstance(optionsBuilder.Options);
        }
    }
}
