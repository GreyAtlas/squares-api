using Squares.Domain.Entities;
using System.Runtime.CompilerServices;

namespace Squares.Application.DTOs
{
    /// <summary>
    /// Represents a 2D point
    /// </summary>
    /// <param name="X">X coordinate</param>
    /// <param name="Y">Y coordinate</param>
    public record PointDTO(int X, int Y)
    {
        public static PointDTO FromEntity(Point point) =>
            new PointDTO(point.X, point.Y);
        public Point ToPoint() =>
            new Point() { X = this.X, Y = this.Y};
    }
}
