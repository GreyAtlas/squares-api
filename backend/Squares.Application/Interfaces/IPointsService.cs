
using Squares.Application.DTOs;
using Squares.Domain.Entities;
using Squares.Domain.ValueObjects;

namespace Squares.Application.Interfaces
{
    public interface IPointsService
    {
        Task<PointList> GetPointListAsync(int listId);
        Task<int> CreatePointListAsync(List<PointDTO> points);
        Task<int> AddPointToListAsync(PointDTO point, int listId);
        Task RemovePointFromListAsync(PointDTO point, int listId);

    }
}
