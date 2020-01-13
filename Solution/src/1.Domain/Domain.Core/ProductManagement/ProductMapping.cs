using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Core.ProductManagement
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
         public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.Name).HasMaxLength(32);
            builder.Property(e => e.Description).HasMaxLength(32);
            builder.Property(e => e.Price).IsRequired();

            builder.HasOne(e => e.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(e => e.CategoryId);

            builder.HasMany(e => e.Items)
                .WithOne(o => o.Product)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
