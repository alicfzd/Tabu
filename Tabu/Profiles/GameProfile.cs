using AutoMapper;
using Tabu.Class;
using Tabu.DTOs.Games;

namespace Tabu.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<GameCreateDto, Game>()
                .ForMember(x => x.BannedWordCount, y => y.MapFrom(z => (int)z.GameLevel))
                .ForMember(g => g.Time, y => y.MapFrom(gcd => new TimeSpan(10000000 * gcd.Seconds)));
        }
    }
}
