using ShapeEngine.Domain.Models;

namespace ShapeEngine.Domain;

public interface IShapeMatcher
{
    public ShapeTypeModel ShapeType { get; }

    public Task<IEnumerable<ShapeMatchResult>> Match(IEnumerable<PointModel> points);
}
