using cetup_api.Data.Entities;

namespace cetup_api.Repositories.Interfaces
{
    public interface IProvinciaRepository
    {
        Task<IEnumerable<Provincia>> GetAllAsync();
        Task<Provincia> GetByIdAsync(int id);

        Task CreateAsync(Provincia provincia);

        Task DeleteAsync(Provincia provincia);

        Task UpdateAsync(Provincia provincia);
    }
}
