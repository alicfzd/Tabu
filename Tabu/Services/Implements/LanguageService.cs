using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tabu.Class;
using Tabu.DAL;
using Tabu.DTOs.Languages;
using Tabu.Services.Abstracts;

namespace Tabu.Services.Implements
{
    public class LanguageService(TabuDbContext _context, IMapper _mapper) : ILanguageService
    {
        public async Task Create(LanguageCreateDto dto)
        {
            var lang = _mapper.Map<Language>(dto);
            await _context.Languages.AddAsync(lang);
            await _context.SaveChangesAsync();
        }
        public async Task<LanguageGetDto> GetByCode(string code)
        {
            var language = await _context.Languages.FirstOrDefaultAsync(l => l.Code == code);
            if (language == null) throw new KeyNotFoundException("Language not found");
            return _mapper.Map<LanguageGetDto>(language);
        }

        public async Task Update(string code, LanguageCreateDto dto)
        {
            var language = await _context.Languages.FirstOrDefaultAsync(l => l.Code == code);
            if (language == null) throw new KeyNotFoundException("Language not found");

            _mapper.Map(dto, language);
            _context.Languages.Update(language);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string code)
        {
            var language = await _context.Languages.FirstOrDefaultAsync(l => l.Code == code);
            if (language == null) throw new KeyNotFoundException("Language not found");

            _context.Languages.Remove(language);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<LanguageGetDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
