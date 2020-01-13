using Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder.Property(e => e.PlacedOn).IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(o => o.Orders)
                .HasForeignKey(e => e.UserId);

            builder.HasMany(e => e.Items)
                .WithOne(i => i.Order);
        }
    }
}
