using Microsoft.AspNetCore.Mvc;
using Squares.Domain.ValueObjects;

namespace Squares.Api.Endpoints
{
    public static class PointsEndpoints
    {
        public static RouteGroupBuilder MapPointEndpoints(this RouteGroupBuilder group)
        {
            group.MapGet("/{id}", async ([FromRoute]int id) =>
            {
                throw new NotImplementedException();
            });

            group.MapGet("/{id}/squares", async ([FromRoute] int id) =>
            {
                throw new NotImplementedException();
            });
            
            group.MapPost("/", async ([FromBody] List<Point> points) =>
            {
                throw new NotImplementedException();
            });

            group.MapPost("/{id}/points", async ([FromRoute] int id,
                                                [FromBody] Point point) =>
            {
                throw new NotImplementedException();
            });

            group.MapDelete("/{id}/points", async ([FromRoute] int id,
                [FromQuery(Name = "x")] int x,
                [FromQuery(Name = "y")] int y) =>
            {
                throw new NotImplementedException();
            });

            return group;
        }
    }
}
