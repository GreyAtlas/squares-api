using Microsoft.EntityFrameworkCore;
using Squares.Application.DTOs;
using Squares.Application.Repositories;
using Squares.Domain.Entities;
using Squares.Infrastructure.Contexts;

namespace Squares.Infrastructure.Repositories
{
    public class PointsRepository : IPointsRepository
    {
        private PointsDbContext _context;
       
        public PointsRepository(PointsDbContext context)
        {
            _context = context;
        }

        public async Task<PointList> GetPointListAsync(int listId)
        {
            var result = await _context
                .PointLists
                .Include(ps => ps.Points)
                .Where(ps => ps.Id == listId)
                .FirstAsync();

            return result;
        }
        public async Task<int> AddPointToListAsync(PointDTO pointDTO, int listId)
        {
            var list = await _context.PointLists
                .Include(pointList => pointList.Points)
                .FirstOrDefaultAsync(pointList => pointList.Id == listId);

            if (list == null) return -1;

            var pointToAdd = new Point() { X = pointDTO.X, Y = pointDTO.Y };

            list.Points.Add(pointToAdd);

            await _context.SaveChangesAsync();
            return listId;
        }

        public async Task<int> CreatePointsListAsync(List<PointDTO> pointDTOs)
        {
            var points = pointDTOs
                                .Select(pointDto =>
                                        pointDto.ToPoint())
                                .ToList();
            var list = new PointList() { Points= points };
            _context.PointLists.Add(list);
            await _context.SaveChangesAsync();
            return list.Id;
        }


        public async Task RemovePointFromListAsync(PointDTO pointDTO, int listId)
        {
            var points = await _context.Points
                .Where(point => EF.Property<int>(point, "PointListId") == listId 
                    && (point.X == pointDTO.X && point.Y == pointDTO.Y))
                .ToListAsync();

            if (!points.Any()) return;

            _context.Points.RemoveRange(points);
            await _context.SaveChangesAsync();
        }
    }
}
