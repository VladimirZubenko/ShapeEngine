using ShapeEngine.Domain.Models;

namespace ShapeEngine.Web.Models;

public class ShapeMatchRequest
{
    public ShapeTypeModel ShapeType { get; set; }

    public PointModel[]? Points { get; set; }
}
