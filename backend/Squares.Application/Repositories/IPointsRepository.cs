using Squares.Application.DTOs;
using Squares.Domain.Entities;

namespace Squares.Application.Repositories
{
    public interface IPointsRepository
    {

        Task<PointList> GetPointListAsync(int listId);
        Task<int> CreatePointsListAsync(List<PointDTO> points);
        Task RemovePointFromListAsync(PointDTO point, int listId);
        Task<int> AddPointToListAsync(PointDTO point, int listId);
    }
}
