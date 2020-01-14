using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rules.UserManagement;

namespace Domain.Core.UserManagement
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired(UserRule.Name.Required)
                .HasMaxLength(UserRule.Name.MaxLength);

            builder.HasMany(m => m.Orders)
                .WithOne(p => p.User)
                .IsRequired(UserRule.Order.Required);
        }
    }
}