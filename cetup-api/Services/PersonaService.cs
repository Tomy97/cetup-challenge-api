using AutoMapper;
using cetup_api.Data.Entities;
using cetup_api.Dtos;
using cetup_api.Repositories.Interfaces;
using cetup_api.Services.Interfaces;

namespace cetup_api.Services
{
    public class PersonaService: IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public PersonaService(IPersonaRepository personaRepository, IMapper mapper)
        {
            _personaRepository = personaRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PersonaDto>> GetAllPersonasAsync()
        {
            IEnumerable<Persona> persona = await _personaRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<PersonaDto>>(persona);
        }

        public async Task<PersonaDto> GetPersonaByIdAsync(int id)
        {
            Persona persona = await _personaRepository.GetByIdAsync(id);
            
            return _mapper.Map<PersonaDto>(persona);
        }

        public async Task<PersonaDto> CreatePersonaAsync(PersonaDto personaDto)
        {
            Persona persona = _mapper.Map<Persona>(personaDto);

            await _personaRepository.AddAsync(persona);

            return _mapper.Map<PersonaDto>(persona);
        }

        public async Task<PersonaDto> UpdatePersonaAsync(PersonaDto personaDto)
        {
            Persona persona = _mapper.Map<Persona>(personaDto);

            await _personaRepository.UpdateAsync(persona);

            return _mapper.Map<PersonaDto>(persona);
        }

        public async Task<PersonaDto> DeletePersonaAsync(int id)
        {
            Persona persona = await _personaRepository.GetByIdAsync(id);

            await _personaRepository.DeleteAsync(persona);

            return _mapper.Map<PersonaDto>(persona);
        }
    }
}
