using Squares.Domain.ValueObjects;

namespace Squares.Application.DTOs
{
    /// <summary>
    /// A set of 4 points representing a Square on a 2D grid
    /// </summary>
    /// <param name="Point1">2D coordinates a corner of a square</param>
    /// <param name="Point2">2D coordinates a corner of a square</param>
    /// <param name="Point3">2D coordinates a corner of a square</param>
    /// <param name="Point4">2D coordinates a corner of a square</param>
    public record SquareDTO(PointDTO Point1, PointDTO Point2, PointDTO Point3, PointDTO Point4) {
        public static SquareDTO FromValueObject(Square square) =>
                new SquareDTO(new PointDTO(square.Point1.X, square.Point1.Y),
                        new PointDTO(square.Point2.X, square.Point2.Y),
                        new PointDTO(square.Point3.X, square.Point3.Y),
                        new PointDTO(square.Point4.X, square.Point4.Y));
    }
}
