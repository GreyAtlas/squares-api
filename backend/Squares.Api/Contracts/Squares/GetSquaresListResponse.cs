using Squares.Application.DTOs;
using Squares.Domain.ValueObjects;

namespace Squares.Api.Contracts.Squares
{
    /// <summary>
    /// A list of sets of 4 points representing squares on a 2D grid
    /// </summary>
    /// <param name="Squares">2D squares</param>
    public record GetSquaresListResponse(List<SquareDTO> Squares)
    {
        public static GetSquaresListResponse FromList(List<Square> squares)
        {
            var squaresDTO = squares.Select(square => SquareDTO.FromValueObject(square)).ToList();

            return new GetSquaresListResponse(squaresDTO);
        }
    }
}
