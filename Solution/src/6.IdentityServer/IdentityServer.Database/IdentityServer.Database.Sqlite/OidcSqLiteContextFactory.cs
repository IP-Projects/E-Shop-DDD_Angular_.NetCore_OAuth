using IdentityServer.Database.SqLite;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Database.SQLite
{
    public class OidcSqLiteContextFactory : OidcSqLiteContextFactoryBase<OidcSqLiteContext>
    {
        protected override OidcSqLiteContext CreateNewInstance(DbContextOptions<OidcSqLiteContext> options)
        {
            return new OidcSqLiteContext(options);
        }
    }
}
