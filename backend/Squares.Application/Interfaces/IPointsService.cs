
using Squares.Application.DTOs;
using Squares.Domain.Entities;
using Squares.Domain.ValueObjects;

namespace Squares.Application.Interfaces
{
    public interface IPointsService
    {
        public Task<PointList> GetPointListAsync(int listId);
        public Task<int> CreatePointListAsync(List<PointDTO> points);
        public Task AddPointToListAsync(PointDTO point, int listId);
        public Task RemovePointFromListAsync(PointDTO point, int listId);

    }
}
