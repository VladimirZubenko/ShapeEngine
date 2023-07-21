using Newtonsoft.Json;
using ShapeEngine.Domain.Models;
using ShapeEngine.Web.Models;
using System.Text;
using Xunit;

namespace ShapeEngine.Tests;

public class RectanglesMatchTest : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly CustomWebApplicationFactory<Program> _factory;

    public RectanglesMatchTest(CustomWebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task TestRectangleShapeTypeSupported()
    {
        // Arrange
        var client = _factory.CreateClient();
        var byteArray = Encoding.ASCII.GetBytes("TestUsername:TestPassword");
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

        // Act
        var response = await client.GetAsync("shape");

        // Assert
        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<string[]>(stringResponse) ?? Array.Empty<string>();
        Assert.Contains("Rectangle", result);
    }

    [Fact]
    public async Task TestShapeMatching()
    {
        // Arrange
        var client = _factory.CreateClient();
        var byteArray = Encoding.ASCII.GetBytes("TestUsername:TestPassword");
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

        var request = new ShapeMatchRequest
        {
            ShapeType = ShapeTypeModel.Rectangle,
            Points = new[]
            {
            new PointModel { X = 2000, Y = 2000 },
            new PointModel { X = 0, Y = 0 },
            new PointModel { X = 2040, Y = 2000 },
        }
        };
        var requestContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

        // Act
        var response = await client.PostAsync("shape/match", requestContent);

        // Assert
        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ShapeMatchResponse>(stringResponse);

#pragma warning disable CS8602, CS8604
        Assert.Equal(3, result.Points.Count());
        Assert.Contains(result.Points, p => p.Point.X == 2000 && p.Point.Y == 2000 && p.ShapeNames.Contains("Rectangle200"));
        Assert.Contains(result.Points, p => p.Point.X == 0 && p.Point.Y == 0 && p.ShapeNames.Contains("Rectangle1"));
        Assert.Contains(result.Points, p => p.Point.X == 2040 && p.Point.Y == 2000 && p.ShapeNames.Contains("Rectangle200"));
#pragma warning restore CS8602, CS8604
    }
}
