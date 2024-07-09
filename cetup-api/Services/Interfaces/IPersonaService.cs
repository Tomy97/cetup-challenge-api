using cetup_api.Dtos;

namespace cetup_api.Services.Interfaces
{
    public interface IPersonaService
    {
        Task<IEnumerable<PersonaDto>> GetAllPersonasAsync();
    }
}
