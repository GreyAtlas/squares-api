using Squares.Domain.ValueObjects;

namespace Squares.Application.DTOs
{
    /// <summary>
    /// A set of 4 points representing a Square on a 2D grid
    /// </summary>
    /// <param name="PointNW">2D coordinates representing the top left corner</param>
    /// <param name="PointNE">2D coordinates representing the top right corner</param>
    /// <param name="PointSE">2D coordinates representing the bottom right corner</param>
    /// <param name="PointSW">2D coordinates representing the bottom left corner</param>
    public record SquareDTO(PointDTO PointNW, PointDTO PointNE, PointDTO PointSE, PointDTO PointSW) {
        public static SquareDTO FromValueObject(Square square) =>
                new SquareDTO(PointDTO.FromEntity(square.PointNW),
                    PointDTO.FromEntity(square.PointNE),
                    PointDTO.FromEntity(square.PointSE), 
                    PointDTO.FromEntity(square.PointSW));
    }
}
