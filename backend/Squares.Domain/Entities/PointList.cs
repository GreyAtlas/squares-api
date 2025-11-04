namespace Squares.Domain.Entities
{
    public class PointList
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Point> Points { get; set; } = new();

        public PointList() { }
    }
}
