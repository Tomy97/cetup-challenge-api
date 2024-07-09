using Microsoft.EntityFrameworkCore;
using cetup_api.Data.Entities;

namespace cetup_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
    }
}
