using Squares.Application.Interfaces;
using Squares.Application.Repositories;
using Squares.Domain.ValueObjects;

namespace Squares.Application.Services
{
    public class SquaresService : ISquaresService
    {   
        private IPointsRepository _pointsRepository;

        public SquaresService(IPointsRepository pointsRepository)
        {
            _pointsRepository = pointsRepository;
        }

        public async Task<List<Square>> FindSquaresInPointListAsync(int listId)
        {
            var pointsList = await _pointsRepository.GetPointListAsync(listId);
            var squares = new List<Square>();
            var coordinateList =  pointsList.Points.Select(point => new Coordinate(point.X, point.Y)).ToList();
            HashSet<Coordinate> coordinateSet = coordinateList.ToHashSet();

            for (int i = 0; i < coordinateList.Count; i++)
            {
                for (int j = 0 + 1; j < coordinateList.Count; j++)
                {
                    var p1 = coordinateList[i];
                    var p2 = coordinateList[j];

                    if (p1 == p2) continue;

                    // Center of imaginary square
                    int middleOfX = (p1.X + p2.X)/2;
                    int middleOfY = (p1.Y + p2.Y)/2;

                    // Vector from center to corner length
                    int dx = (p2.X - middleOfX);
                    int dy = (p2.Y - middleOfY);

                    // ensure middle point is on integer grid
                    if ((dx + dy) % 2 != 0) continue;

                    // 90 and 270 degree rotations from the middle point
                    var p3 = new Coordinate((middleOfX  - dy ), (middleOfY + dx));
                    var p4 = new Coordinate((middleOfX + dy), (middleOfY - dx));

                    //if points are in the set, add an ordered square to found squares.
                    if (coordinateSet.Contains(p3) && coordinateSet.Contains(p4))
                    {
                        var orderedPoints = new[] { p1, p2, p3, p4 }
                           .OrderBy(p => p.X)
                           .ThenBy(p => p.Y)
                           .ToArray();

                        squares.Add(new Square(orderedPoints[0], orderedPoints[1],
                                              orderedPoints[2], orderedPoints[3]));
                    }
                }
            }
            return squares.Distinct().ToList();
        }
    }
}
