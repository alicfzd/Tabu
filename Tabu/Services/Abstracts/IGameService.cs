using Tabu.DTOs.Games;

namespace Tabu.Services.Abstracts
{
    public interface IGameService
    {
        Task<Guid> AddAsync(GameCreateDto dto);
    }
}
