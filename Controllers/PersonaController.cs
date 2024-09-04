using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDO.DATABDD;

namespace WebApiDO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ILogger<PersonaController> _logger;
        private readonly ApplicationDbContext _db;

        public PersonaController(ApplicationDbContext db, ILogger<PersonaController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetPersonas()
        {
            var personas = _db.Personas.ToList();
            return Ok(personas);
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonaById(int id)
        {
            var persona = _db.Personas.FirstOrDefault(p => p.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            return Ok(persona);
        }

        [HttpPut("{id}")]
        public IActionResult EditPersona(int id, [FromBody] Persona persona)
        {
            var existingPersona = _db.Personas.FirstOrDefault(p => p.Id == id);
            if (existingPersona == null)
            {
                return NotFound();
            }

            existingPersona.IdDatos = persona.IdDatos;
            existingPersona.IdPersona = persona.IdPersona;
            existingPersona.Inputdatovalor = persona.Inputdatovalor;
            existingPersona.FechaIngreso = persona.FechaIngreso;
            existingPersona.FechaActualiza = DateTime.Now;

            _db.Personas.Update(existingPersona);
            _db.SaveChanges();

            return Ok(existingPersona);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePersona(int id)
        {
            var persona = _db.Personas.FirstOrDefault(p => p.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            _db.Personas.Remove(persona);
            _db.SaveChanges();

            return Ok();
        }
    }
}
