using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelsLibrary.Models;

namespace CoreLibrary.Config;

public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(c => c.CategoryId).IsRequired();
        builder.Property(c => c.Name).IsRequired().HasMaxLength(128);
        builder.Property(c => c.DisplayOrder).IsRequired();
    }
}