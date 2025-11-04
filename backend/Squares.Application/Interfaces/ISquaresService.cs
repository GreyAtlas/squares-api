using Squares.Domain.ValueObjects;

namespace Squares.Application.Interfaces
{
    public interface ISquaresService
    {
        public Task<List<Square>> FindSquaresInPointListAsync(int listId);
    }
}
