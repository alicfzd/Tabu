using Tabu.DTOs.Languages;

namespace Tabu.Services.Abstracts
{
    public interface ILanguageService
    {
        IEnumerable<LanguageGetDto> GetAll();
        Task<LanguageGetDto> GetByCode(string code); 
        Task Create(LanguageCreateDto dto);
        Task Update(string code, LanguageCreateDto dto); 
        Task Delete(string code);
    }
}
