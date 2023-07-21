using Microsoft.EntityFrameworkCore;
using ShapeEngine.Data.Models;

namespace ShapeEngine.Data.Repositories;

public class ShapeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ShapeRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Shape>> GetAll(ShapeType shapeType)
        => await _dbContext.Shapes
        .AsNoTracking()
        .Where(x => x.ShapeType == shapeType)
        .Include(x => x.Points)
        .ToArrayAsync();
}
