using cetup_api.Data;
using cetup_api.Data.Entities;
using cetup_api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cetup_api.Repositories
{
    public class PersonaRepository: IPersonaRepository
    {
        private readonly AppDbContext _context;

        public PersonaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Persona>> GetAllAsync() => await _context.Personas.ToListAsync();

        public async Task<Persona> GetByIdAsync(int id) => await _context.Personas.FirstOrDefaultAsync(x => x.Id == id);

        public async Task AddAsync(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Persona persona)
        {
            _context.Personas.Update(persona);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Persona persona)
        {
            var personaToDelete = await _context.Personas.FirstOrDefaultAsync(x => x.Id == persona.Id);
            _context.Personas.Remove(personaToDelete!);
            await _context.SaveChangesAsync();
        }
    }
}
