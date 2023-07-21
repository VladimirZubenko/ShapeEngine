using ShapeEngine.Data.Models;
using ShapeEngine.Domain.Models;

namespace ShapeEngine.Domain.Mappers;

public class ShapeTypeMapper
{
    public ShapeType Map(ShapeTypeModel shapeTypeModel)
    {
        switch (shapeTypeModel)
        {
            case ShapeTypeModel.Rectangle:
                return ShapeType.Rectangle;
            default:
                throw new ArgumentException($"Unsupported shape type: {shapeTypeModel}");
        }
    }
}
