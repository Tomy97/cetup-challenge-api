using cetup_api.Data;
using cetup_api.Data.Entities;
using cetup_api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cetup_api.Repositories
{

    public class ProvinciaRepository : IProvinciaRepository
    {
        private readonly AppDbContext _context;

        public ProvinciaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Provincia>> GetAllAsync() => await _context.Provincias.ToListAsync();

        public async Task<Provincia> GetByIdAsync(int id) => await _context.Provincias.FirstOrDefaultAsync(x => x.Id == id);

        public async Task CreateAsync(Provincia provincia)
        {
            bool hasExist = _context.Provincias.Any(x => x.Nombre == provincia.Nombre);

            if (hasExist)
            {
                throw new Exception("Ya existe esta provincia");
            }
            await _context.Provincias.AddAsync(provincia);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Provincia provincia)
        {
            _context.Provincias.Remove(provincia);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Provincia provincia)
        {
            _context.Provincias.Update(provincia);
            await _context.SaveChangesAsync();
        }
    }
}
