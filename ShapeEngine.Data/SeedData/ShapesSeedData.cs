using ShapeEngine.Data.Models;

namespace ShapeEngine.Data.SeedData;

public static class ShapesSeedData
{
    public static (IEnumerable<Shape> Shapes, IEnumerable<Point> Points) GetData(int count)
    {
        var shapes = GetShapesData(count);
        var points = GetPointsData(shapes);

        return (shapes, points);
    }

    private static List<Shape> GetShapesData(int count)
    {
        var shapes = new List<Shape>();

        for (var i = 0; i < count; i++)
        {
            var shapeName = $"Rectangle{i + 1}";
            var shapeId = GenerateGuidBasedOnName(shapeName);
            shapes.Add(new Shape(shapeId, ShapeType.Rectangle, shapeName));
        }

        return shapes;
    }

    private static List<Point> GetPointsData(List<Shape> shapes)
    {
        var points = new List<Point>();

        for (var i = 0; i < shapes.Count; i++)
        {
            var shape = shapes[i];
            var topLeftPointName = $"TopLeftPoint{i + 1}";
            var bottomRightPointName = $"BottomRightPoint{i + 1}";

            points.Add(new Point(GenerateGuidBasedOnName(topLeftPointName), shape.Id, PointType.TopLeft, i * 10, i * 10));
            points.Add(new Point(GenerateGuidBasedOnName(bottomRightPointName), shape.Id, PointType.BottomRight, i * 10 + 50, i * 10 + 25));
        }

        return points;
    }

    private static Guid GenerateGuidBasedOnName(string name)
    {
        using var md5 = System.Security.Cryptography.MD5.Create();
        var hash = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(name));

        return new Guid(hash);
    }
}
