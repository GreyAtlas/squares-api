using Squares.Domain.Entities;

namespace Squares.Domain.ValueObjects
{
    public record Square
    {
        public required Point PointNW;
        public required Point PointNE;
        public required Point PointSE;
        public required Point PointSW;
    }
}
