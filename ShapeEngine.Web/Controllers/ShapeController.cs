using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShapeEngine.Domain;
using ShapeEngine.Domain.Models;
using ShapeEngine.Web.Mappers;
using ShapeEngine.Web.Models;

namespace ShapeEngine.Web.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ShapeController : ControllerBase
{
    private readonly ILogger<ShapeController> _logger;
    private readonly IEnumerable<IShapeMatcher> _shapeMatchers;
    private readonly ShapeMatchResultToResponseMapper _shapeMatchResultToResponseMapper;

    public ShapeController(
        ILogger<ShapeController> logger,
        IEnumerable<IShapeMatcher> shapeMatchers,
        ShapeMatchResultToResponseMapper shapeMatchResultToResponseMapper)
    {
        _logger = logger;
        _shapeMatchers = shapeMatchers;
        _shapeMatchResultToResponseMapper = shapeMatchResultToResponseMapper;
    }

    [HttpGet]
    public IEnumerable<string?> GetSupportedShapeTypes() => Enum.GetNames(typeof(ShapeTypeModel));

    [HttpPost("match")]
    public async Task<ActionResult<ShapeMatchResponse>> Match([FromBody] ShapeMatchRequest request)
    {
        try
        {
            if (request == null)
                throw new Exception("Empty model.");

            if (!Enum.IsDefined(typeof(ShapeTypeModel), request.ShapeType))
                throw new Exception("Invalid ShapeType.");

            if (request.Points == null || !request.Points.Any())
                throw new Exception("Empty Points.");

            var shapeMatcher = _shapeMatchers.FirstOrDefault(x => x.ShapeType == request.ShapeType)
                ?? throw new Exception($"Can't find shape matcher for {request.ShapeType}.");

            var resultData = await shapeMatcher.Match(request.Points);
            var result = _shapeMatchResultToResponseMapper.Map(resultData);

            return Ok(result);
        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{nameof(ShapeController)}: Problems with handling.");

            return BadRequest(new { e.Message });
        }
    }
}
