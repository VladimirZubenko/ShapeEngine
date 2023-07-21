using ShapeEngine.Domain.Models;

namespace ShapeEngine.Web.Models;

public class ShapeMatchResponse
{
    public IEnumerable<ShapeMatchResponseRow>? Points { get; set; }
}

public class ShapeMatchResponseRow
{
    public PointModel? Point { get; set; }

    public IEnumerable<string?>? ShapeNames { get; set; }
}
