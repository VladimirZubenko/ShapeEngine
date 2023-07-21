using Microsoft.EntityFrameworkCore;
using ShapeEngine.Data.Models;
using ShapeEngine.Data.SeedData;

namespace ShapeEngine.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Shape> Shapes { get; set; }

    public DbSet<Point> Points { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Point>()
            .HasOne(x => x.Shape)
            .WithMany(x => x.Points)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Shape>()
            .HasIndex(b => b.Name);

        var shapesSeedData = ShapesSeedData.GetData(200);
        modelBuilder.Entity<Shape>().HasData(shapesSeedData.Shapes);
        modelBuilder.Entity<Point>().HasData(shapesSeedData.Points);

        base.OnModelCreating(modelBuilder);
    }
}
