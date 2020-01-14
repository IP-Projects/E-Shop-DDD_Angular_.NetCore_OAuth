using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rules.OrderItemsManagement;
using Rules.OrderManagement;

namespace Domain.Core.OrderItemsManagement
{
    public class OrderMapping : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.HasKey(e => new { e.OrderId, e.ProductId });

            builder.HasOne(e => e.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(e => e.OrderId)
                .IsRequired(OrderItemsRule.Order.Required);
                

            builder.HasOne(e => e.Product)
                .WithMany(p => p.Items)
                .HasForeignKey(e => e.ProductId)
                .IsRequired(OrderItemsRule.Product.Required);

            builder.Property(p => p.Quantity)
                .IsRequired(OrderItemsRule.Quantity.Required)
                .HasDefaultValue(OrderItemsRule.Quantity.DefaultValue);
        }
    }
}
