using Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rules.OrderManagement;

namespace Domain.Core.OrderManagement
{
    public class ProductMapping : IEntityTypeConfiguration<Order>
    {
        /// <summary>
        ///     Configure the Product entity.
        /// </summary>
        /// <param name="builder">Entity configurator</param>
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.PlacedOn)
                .IsRequired(OrderRule.PlacedOn.Required);

            builder.HasOne(e => e.User)
                .WithMany(m => m.Orders)
                .HasForeignKey(e => e.UserId)
                .IsRequired(OrderRule.User.Required);

            builder.HasMany(e => e.Items)
                .WithOne(i => i.Order)
                .IsRequired(OrderRule.Items.Required);
        }
    }
}
