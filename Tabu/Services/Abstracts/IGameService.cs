using Tabu.Class;
using Tabu.DTOs.Games;
using Tabu.DTOs.Word;

namespace Tabu.Services.Abstracts
{
    public interface IGameService
    {
        Task<Guid> AddAsync(GameCreateDto dto);
        Task<WordForGameDto> StartAsync(Guid id);
        Task<Game> GetCurrentStatus(Guid id);
        Task<WordForGameDto> PassAsync(Guid id);
        Task<WordForGameDto> SuccessAsync(Guid id);
        Task<WordForGameDto> WrongAsync(Guid id);
        Task EndAsync(Guid id);
    }
}
