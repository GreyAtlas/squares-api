using Squares.Domain.ValueObjects;

namespace Squares.Domain.Entities
{
    public class PointList
    {
        public int Id;
        public List<Point> Points;

        public PointList(int id, List<Point> points)
        {
            Id = id;
            Points = points;
        }
    }
}
