using Tabu.DTOs.Word;
using Tabu.Entities;

namespace Tabu.Services.Abstracts
{
    public interface IWordService
    {
        Task<int> CreateAsync(WordCreateDto dto);
        Task<IEnumerable<Word>> GetAllAsync();
    }
}
