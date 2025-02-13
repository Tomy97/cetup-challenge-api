﻿using cetup_api.Dtos;

namespace cetup_api.Services.Interfaces
{
    public interface IProvinciaService
    {
        Task<IEnumerable<ProvinciaDto>> GetAllProvinciasAsync();
        Task<ProvinciaDto> GetProvinciaByIdAsync(int id);

        Task<ProvinciaDto> CreateProvinciaAsync(ProvinciaDto provinciaDto);

        Task<ProvinciaDto> DeleteProvinciaAsync(int id);

        Task<ProvinciaDto> UpdateProvinciaAsync(ProvinciaDto provinciaDto);
    }
}
