using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rules.ProductManagement;

namespace Domain.Core.ProductManagement
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
         public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired(ProductRule.Name.Required)
                .HasMaxLength(ProductRule.Name.MaxLength);

            builder.Property(e => e.Description)
                .IsRequired(ProductRule.Description.Required)
                .HasMaxLength(ProductRule.Description.MaxLength);

            builder.Property(e => e.CoverImageName)
                .IsRequired(ProductRule.CoverImageName.Required)
                .HasMaxLength(ProductRule.CoverImageName.MaxLength);

            builder.Property(e => e.Price)
                .IsRequired(ProductRule.Price.Required);

            builder.HasOne(e => e.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired(ProductRule.Category.Required);

            builder.HasMany(e => e.Items)
                .WithOne(o => o.Product)
                .HasForeignKey(p => p.ProductId)
                .IsRequired(ProductRule.Items.Required);
        }
    }
}
