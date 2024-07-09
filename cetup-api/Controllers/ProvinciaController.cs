using cetup_api.Dtos;
using cetup_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cetup_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {

        private readonly IProvinciaService _provinciaService;


        public ProvinciaController(IProvinciaService provinciaService)
        {
            _provinciaService = provinciaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvinciaDto>>> GetProvincias()
        {
            var provincias = await _provinciaService.GetAllProvinciasAsync();
            return Ok(provincias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinciaDto>> GetProvincia(int id)
        {
            var provincia = await _provinciaService.GetProvinciaByIdAsync(id);
            if (provincia == null)
            {
                return NotFound();
            }
            return Ok(provincia);
        }

        [HttpPost]
        public async Task<ActionResult<ProvinciaDto>> CreateProvincia([FromBody] ProvinciaDto provinciaDto)
        {
            var provincia = await _provinciaService.CreateProvinciaAsync(provinciaDto);
            return CreatedAtAction(nameof(GetProvincia), new { id = provincia.Id }, provincia);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<ProvinciaDto>> UpdateProvincia([FromBody] ProvinciaDto provinciaDto)
        {
            var provincia = await _provinciaService.UpdateProvinciaAsync(provinciaDto);
            return CreatedAtAction(nameof(GetProvincia), new { id = provincia.Id }, provincia);
        }

        [HttpDelete]
        public async Task<ActionResult<ProvinciaDto>> DeleteProvincia([FromBody] ProvinciaDto provinciaDto)
        {
            var provincia = await _provinciaService.DeleteProvinciaAsync(provinciaDto);
            return CreatedAtAction(nameof(GetProvincia), new { id = provincia.Id }, provincia);
        }

    }
}
