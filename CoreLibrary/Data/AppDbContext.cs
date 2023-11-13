using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary.Models;

namespace CoreLibrary.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Category>().HasData
        (
            new Category { Id = 1, Name = "Aksiyon", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Bilim Kurgu", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Tarih", DisplayOrder = 3 }
        );
    }
}