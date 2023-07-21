using ShapeEngine.Domain.Models;
using ShapeEngine.Web.Models;

namespace ShapeEngine.Web.Mappers;

public class ShapeMatchResultToResponseMapper
{
    public ShapeMatchResponse Map(IEnumerable<ShapeMatchResult> data)
    {
        return new ShapeMatchResponse
        {
            Points = data.Select(x => new ShapeMatchResponseRow
            {
                Point = x.Point,
                ShapeNames = x.Names
            })
        };
    }
}

