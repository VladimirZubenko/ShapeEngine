using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using ShapeEngine.Data;
using ShapeEngine.Data.Repositories;
using ShapeEngine.Domain;
using ShapeEngine.Domain.Mappers;
using ShapeEngine.Web.Infrastructure;
using ShapeEngine.Web.Mappers;

var builder = WebApplication.CreateBuilder(args);

if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Test")
    builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("InMemoryDb"));
else
    builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(GetValue("ConnectionString")));

builder.Services.AddTransient<IShapeMatcher, RectangleMatcher>();
builder.Services.AddTransient<ShapeRepository>();
builder.Services.AddTransient<ShapeTypeMapper>();
builder.Services.AddTransient<ShapeMatchResultToResponseMapper>();

builder.Services.AddSingleton(
    x => new ApplicationSettings
    {
        BasicAuthUsername = GetValue(nameof(ApplicationSettings.BasicAuthUsername)),
        BasicAuthPassword = GetValue(nameof(ApplicationSettings.BasicAuthPassword))
    });

builder.Services.AddControllers();

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static string? GetValue(string key) => Environment.GetEnvironmentVariable(key);

public partial class Program { }
