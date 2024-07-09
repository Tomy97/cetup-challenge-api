using cetup_api.Dtos;
using cetup_api.Services.Interfaces;

namespace cetup_api.Services
{
    public class PersonaService: IPersonaService
    {
        public Task<IEnumerable<PersonaDto>> GetAllPersonasAsync()
        {
            throw new NotImplementedException();
        }
    }
}
