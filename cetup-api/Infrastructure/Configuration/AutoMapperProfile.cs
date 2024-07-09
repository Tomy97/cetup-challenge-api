using AutoMapper;
using cetup_api.Data.Entities;
using cetup_api.Dtos;

namespace cetup_api.Infrastructure.Configuration
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Provincia, ProvinciaDto>().ReverseMap();
            CreateMap<Persona, PersonaDto>().ReverseMap();
        }
    }
}
