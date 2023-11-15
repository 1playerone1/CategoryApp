using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Config;

public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Name).IsRequired().HasMaxLength(128);
        builder.Property(c => c.DisplayOrder).IsRequired();
    }
}