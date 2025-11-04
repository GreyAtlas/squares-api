using Squares.Application.DTOs;

namespace Squares.Api.Contracts.Points
{
    /// <summary>
    /// A list of points on a 2D grid
    /// </summary>
    /// <param name="Points">List of points</param>
    public record CreatePointsListRequest(List<PointDTO> Points);
}
