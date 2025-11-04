using Squares.Domain.Entities;

namespace Squares.Domain.ValueObjects
{
    public record Square(Coordinate Point1, Coordinate Point2, Coordinate Point3, Coordinate Point4);
}
