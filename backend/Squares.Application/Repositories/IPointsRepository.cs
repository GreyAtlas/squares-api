using Squares.Domain.ValueObjects;

namespace Squares.Application.Repositories
{
    public interface IPointsRepository
    {
        public int CreatePointsList(List<Point> points);
        public int RemovePointFromList(Point point, int listId);
        public int AddPointToList(Point point, int listId);
    }
}
