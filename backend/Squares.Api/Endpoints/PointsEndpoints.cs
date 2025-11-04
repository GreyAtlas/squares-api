using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Squares.Api.Contracts.Points;
using Squares.Api.Contracts.Squares;
using Squares.Application.DTOs;
using Squares.Application.Interfaces;

namespace Squares.Api.Endpoints
{
    public static class PointsEndpoints
    {
        public static RouteGroupBuilder MapPointsEndpoints(this RouteGroupBuilder group)
        {
            group.MapGet("/{id}",
                async Task<Results<Ok<GetPointsListResponse>, NotFound>>
                    ([FromRoute] int id, 
                    [FromServices] IPointsService pointsService) =>
            {
                var pointsList = await pointsService.GetPointListAsync(id);

                return pointsList == null
                    ? TypedResults.NotFound()
                    : TypedResults.Ok(GetPointsListResponse.FromEntity(pointsList));
            });

            group.MapGet("/{id}/squares",
                async Task<Results<Ok<GetSquaresListResponse>, NotFound>> 
                ([FromRoute] int id,
                [FromServices] ISquaresService squaresService) =>
            {
                var squaresList = await squaresService.FindSquaresInPointListAsync(id);

                return squaresList == null
                    ? TypedResults.NotFound()
                    : TypedResults.Ok(GetSquaresListResponse.FromList(squaresList));
            });
            
            group.MapPost("/",
                async Task<Ok>
                ([FromBody] CreatePointsListRequest createPointsListRequest,
                [FromServices] IPointsService pointsService) =>
            {
                await pointsService.CreatePointListAsync(createPointsListRequest.Points);
                return TypedResults.Ok();
            });

            group.MapPost("/{id}/points", 
                async Task<Results<Ok, NotFound>>
                ([FromRoute] int id,
                [FromBody] PointDTO point,
                [FromServices] IPointsService pointsService) =>
            {
                try
                {
                    await pointsService.AddPointToListAsync(point, id);
                }
                catch
                {
                    return TypedResults.NotFound();
                }

                return TypedResults.Ok();
            });

            group.MapDelete("/{id}/points", 
                async Task<Results<Ok, NotFound>>
                (
                [FromRoute] int id,
                [FromQuery(Name = "x")] int x,
                [FromQuery(Name = "y")] int y,
                [FromServices] IPointsService pointsService) =>
            {
                try
                {
                    await pointsService.RemovePointFromListAsync(new PointDTO(x, y), id);
                }
                catch
                {
                    return TypedResults.NotFound();
                }
                return TypedResults.Ok();
            });

            return group;
        }
    }
}
