using System;
using Domain.Core.DatabaseContext;
using IdentityServer.Core.UserManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityServer.Database.SqlServer
{
    public class OidcSqlServerContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public OidcSqlServerContext(DbContextOptions<OidcSqlServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMapping).Assembly);
        }
    }
}
