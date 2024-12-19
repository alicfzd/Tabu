using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tabu.Class;
using Tabu.DAL;
using Tabu.DTOs.Languages;
using Tabu.Exceptions.Languages;
using Tabu.Services.Abstracts;

namespace Tabu.Services.Implements
{
    public class LanguageService(TabuDbContext _context, IMapper _mapper) : ILanguageService
    {
        public async Task CreateAsync(LanguageCreateDto dto)
        {
            if (await _context.Languages.AnyAsync(x => x.Code == dto.Code))
                throw new LanguageExistsException();
            var lang = _mapper.Map<Language>(dto);
            await _context.Languages.AddAsync(lang);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(string code, LanguageCreateDto dto)
        {
            var data = await _getByCode(code);
            if (data == null) throw new LanguageNotFoundException();
            _mapper.Map(dto, data);
            _context.Languages.Update(data);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string code)
        {
            var language = await _context.Languages.FirstOrDefaultAsync(l => l.Code == code);
            if (language == null) throw new KeyNotFoundException("Language not found");

            _context.Languages.Remove(language);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<LanguageGetDto>> GetAllAsync()
        {
            var langs = await _context.Languages.ToListAsync();
            return _mapper.Map< IEnumerable<LanguageGetDto>>(langs);

        }

        public Task<LanguageGetDto> GetByCode(string code)
        {
            throw new NotImplementedException();
        }
        async Task<Language?> _getByCode(string code)
            => await _context.Languages.FindAsync(code);

        public Task CreateAsyc(LanguageCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string code, LanguageUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
