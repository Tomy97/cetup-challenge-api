using cetup_api.Dtos;

namespace cetup_api.Services.Interfaces
{
    public interface IPersonaService
    {
        Task<IEnumerable<PersonaDto>> GetAllPersonasAsync();

        Task<PersonaDto> GetPersonaByIdAsync(int id);

        Task<PersonaDto> CreatePersonaAsync(PersonaDto personaDto);

        Task<PersonaDto> UpdatePersonaAsync(PersonaDto personaDto);

        Task<PersonaDto> DeletePersonaAsync(int id);

    }
}
