using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Database.SqlServer
{
    public class OidcSqlServerContextFactory : OidcSqlServerContextFactoryBase<OidcSqlServerContext>
    {
        protected override OidcSqlServerContext CreateNewInstance(DbContextOptions<OidcSqlServerContext> options)
        {
            return new OidcSqlServerContext(options);
        }
    }
}
