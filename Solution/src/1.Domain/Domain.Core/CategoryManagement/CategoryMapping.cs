using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rules.CategoryManagement;

namespace Domain.Core.CategoryManagement
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(CategoryRule.Name.MaxLength)
                .IsRequired(CategoryRule.Name.Required);

            builder.HasMany(e => e.Products)
                .WithOne(p => p.Category)
                .IsRequired(CategoryRule.Products.Required);
        }
    }
}
