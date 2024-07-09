using AutoMapper;
using cetup_api.Data.Entities;
using cetup_api.Dtos;
using cetup_api.Repositories.Interfaces;
using cetup_api.Services.Interfaces;

namespace cetup_api.Services
{
    public class ProvinciaService : IProvinciaService
    {
        private readonly IProvinciaRepository _provinciaRepository;
        private readonly IMapper _mapper;

        public ProvinciaService(IProvinciaRepository provinciaRepository, IMapper mapper)
        {
            _provinciaRepository = provinciaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProvinciaDto>> GetAllProvinciasAsync()
        {
            var provincias = await _provinciaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProvinciaDto>>(provincias);
        }

        public async Task<ProvinciaDto> GetProvinciaByIdAsync(int id)
        {
            Provincia provincia = await _provinciaRepository.GetByIdAsync(id);
            return _mapper.Map<ProvinciaDto>(provincia);
        }

        public async Task<ProvinciaDto> CreateProvinciaAsync(ProvinciaDto provinciaDto)
        {
            Provincia provincia = _mapper.Map<Provincia>(provinciaDto);

            await _provinciaRepository.CreateAsync(provincia);
            return _mapper.Map<ProvinciaDto>(provincia);
        }

        public async Task<ProvinciaDto> DeleteProvinciaAsync(ProvinciaDto provinciaDto)
        {
            Provincia provincia = _mapper.Map<Provincia>(provinciaDto);
            await _provinciaRepository.DeleteAsync(provincia);
            return _mapper.Map<ProvinciaDto>(provincia);
        }

        public async Task<ProvinciaDto> UpdateProvinciaAsync(ProvinciaDto provinciaDto)
        {
            Provincia provincia = _mapper.Map<Provincia>(provinciaDto);
            await _provinciaRepository.UpdateAsync(provincia);
            return _mapper.Map<ProvinciaDto>(provincia);
        }
    }
}
