using cetup_api.Dtos;
using cetup_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cetup_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }
        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> GetPersonaController()
        {
            try
            {
                var personas = await _personaService.GetAllPersonasAsync();

                return Ok(personas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> GetPersonaController(int id)
        {
            try
            {
                var persona = await _personaService.GetPersonaByIdAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<PersonaController>
        [HttpPost]
        public async Task<ActionResult<PersonaDto>> CreatePersonaController([FromBody] PersonaDto personaDto)
        {
            try
            {
                var persona = await _personaService.CreatePersonaAsync(personaDto);
                return CreatedAtAction(nameof(GetPersonaController), new { id = persona.Id }, persona);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<PersonaDto>> UpdatePersonaController([FromBody] PersonaDto personaDto)
        {
            try
            {
                var persona = await _personaService.UpdatePersonaAsync(personaDto);
                return CreatedAtAction(nameof(GetPersonaController), new { id = persona.Id }, persona);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
