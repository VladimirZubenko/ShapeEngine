namespace ShapeEngine.Domain.Models;

public class ShapeMatchResult
{
    public PointModel? Point { get; set; }

    public IEnumerable<string?>? Names { get; set; }
}
