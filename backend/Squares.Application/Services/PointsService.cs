using Squares.Application.DTOs;
using Squares.Application.Interfaces;
using Squares.Application.Repositories;
using Squares.Domain.Entities;

namespace Squares.Application.Services
{
    public class PointsService : IPointsService
    {
        private IPointsRepository _pointsRepository;
        public PointsService(IPointsRepository pointsRepository) {
            _pointsRepository = pointsRepository;
        }
        public async Task<int> AddPointToListAsync(PointDTO point, int listId)
        {
            return await _pointsRepository.AddPointToListAsync(point, listId);
        }

        public async Task<int> CreatePointListAsync(List<PointDTO> points)
        {
            return await _pointsRepository.CreatePointsListAsync(points);
        }

        public async Task<PointList> GetPointListAsync(int listId)
        {
            return await _pointsRepository.GetPointListAsync(listId);
        }

        public async Task RemovePointFromListAsync(PointDTO pointDTO, int listId)
        {
            await _pointsRepository.RemovePointFromListAsync(pointDTO, listId);
        }
    }
}
