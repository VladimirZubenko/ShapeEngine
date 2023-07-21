using System.ComponentModel.DataAnnotations;

namespace ShapeEngine.Data.Models;

public class Point
{
    public Point() { }

    [Key]
    public Guid Id { get; set; }

    public Point(Guid id, Guid shapeId, PointType pointType, long x, long y)
    {
        Id = id;
        ShapeId = shapeId;
        PointType = pointType;
        X = x;
        Y = y;
    }

    public Guid ShapeId { get; set; }
    public Shape? Shape { get; set; }

    public PointType PointType { get; set; }

    public long X { get; set; }

    public long Y { get; set; }
}
