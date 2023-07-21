using System.ComponentModel.DataAnnotations;

namespace ShapeEngine.Data.Models;

public class Shape
{
    public Shape() { }

    public Shape(Guid id, ShapeType shapeType, string? name)
    {
        Id = id;
        ShapeType = shapeType;
        Name = name;
    }

    [Key]
    public Guid Id { get; set; }

    public ShapeType ShapeType { get; set; }

    public string? Name { get; set; }

    public ICollection<Point>? Points { get; set; }
}
