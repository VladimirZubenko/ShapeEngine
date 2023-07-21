using ShapeEngine.Data.Models;
using ShapeEngine.Data.Repositories;
using ShapeEngine.Domain.Mappers;
using ShapeEngine.Domain.Models;

namespace ShapeEngine.Domain;

public class RectangleMatcher : IShapeMatcher
{
    private readonly ShapeRepository _shapeRepository;
    private readonly ShapeTypeMapper _shapeTypeMapper;

    public RectangleMatcher(
        ShapeRepository shapeRepository,
        ShapeTypeMapper shapeTypeMapper)
    {
        _shapeRepository = shapeRepository;
        _shapeTypeMapper = shapeTypeMapper;
    }

    public ShapeTypeModel ShapeType => ShapeTypeModel.Rectangle;

    public async Task<IEnumerable<ShapeMatchResult>> Match(IEnumerable<PointModel> points)
    {
        var result = new List<ShapeMatchResult>();

        var shapeType = _shapeTypeMapper.Map(ShapeType);
        var allRectangles = await _shapeRepository.GetAll(shapeType);

        foreach (var point in points)
        {
            var matchingRectangles = new List<string?>();

            foreach (var rectangle in allRectangles)
                if (PointInRectangle(rectangle, point))
                    matchingRectangles.Add(rectangle.Name);

            result.Add(new ShapeMatchResult { Point = point, Names = matchingRectangles });
        }

        return result;
    }

    private bool PointInRectangle(Shape rectangle, PointModel point)
    {
        var topLeftPoint = rectangle.Points?.FirstOrDefault(x => x.PointType == PointType.TopLeft);
        var bottomRight = rectangle.Points?.FirstOrDefault(x => x.PointType == PointType.BottomRight);

        if (topLeftPoint == null || bottomRight == null)
            return false;

        return point.X >= topLeftPoint.X &&
               point.X <= bottomRight.X &&
               point.Y >= topLeftPoint.Y &&
               point.Y <= bottomRight.Y;
    }
}
