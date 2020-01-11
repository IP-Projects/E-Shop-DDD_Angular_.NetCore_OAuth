using System;
using Domain.Core.DatabaseContext;
using IdentityServer.Core.UserManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Database.SQLite
{
    public class OidcSqLiteContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public OidcSqLiteContext(DbContextOptions<OidcSqLiteContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMapping).Assembly);
        }
    }
}
