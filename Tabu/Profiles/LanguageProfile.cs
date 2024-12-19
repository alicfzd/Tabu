using AutoMapper;
using Tabu.Class;
using Tabu.DTOs.Languages;

namespace Tabu.Profiles
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile() 
        {
            CreateMap<LanguageCreateDto, Language>()
                .ForMember(l => l.Icon, d => d.MapFrom(t => t.IconUrl));
            CreateMap<Language, LanguageGetDto>();
            CreateMap<LanguageUpdateDto, Language>();
        }
    }
}
