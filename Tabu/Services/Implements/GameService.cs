using AutoMapper;
using Tabu.Class;
using Tabu.DAL;
using Tabu.DTOs.Games;
using Tabu.Services.Abstracts;

namespace Tabu.Services.Implements
{
    public class GameService(IMapper _mapper, TabuDbContext _context) : IGameService
    {
        public async Task<Guid> AddAsync(GameCreateDto dto)
        {
            var entity = _mapper.Map<Game>(dto);
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
        public async Task StartAsync(Guid id)
        {
            var entity =  await _context.Games.FindAsync(id);
        }
    }
}
