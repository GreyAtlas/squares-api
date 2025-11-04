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
    public record SquareDTO(PointDTO Point1, PointDTO Point2, PointDTO Point3, PointDTO Point4) {
        public static SquareDTO FromValueObject(Square square) =>
                new SquareDTO(new PointDTO(square.Point1.X, square.Point1.Y),
                        new PointDTO(square.Point2.X, square.Point2.Y),
                        new PointDTO(square.Point3.X, square.Point3.Y),
                        new PointDTO(square.Point4.X, square.Point4.Y));
    }
}
