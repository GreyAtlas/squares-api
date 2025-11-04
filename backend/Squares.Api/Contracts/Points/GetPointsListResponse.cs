using Squares.Application.DTOs;
using Squares.Domain.Entities;

namespace Squares.Api.Contracts.Points
{
    /// <summary>
    /// Represents a list of points with the given Id
    /// </summary>
    /// <param name="Points">A list of 2D points</param>
    public record GetPointsListResponse(List<PointDTO> Points)
    {
        public static GetPointsListResponse FromEntity(PointList pointList)
        {
            var points = pointList.Points.Select(p => new PointDTO(p.X, p.Y)).ToList();

            return new GetPointsListResponse(
                Points: points
                );
        }
    }
    
}
