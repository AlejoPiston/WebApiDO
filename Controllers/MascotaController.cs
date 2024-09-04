using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDO.DATABDD;

namespace WebApiDO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly ILogger<MascotaController> _logger;
        private readonly ApplicationDbContext _db;

        public MascotaController(ApplicationDbContext db, ILogger<MascotaController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetMascotas()
        {
            var mascotas = _db.Mascota.ToList();
            return Ok(mascotas);
        }

        [HttpGet("{id}")]
        public IActionResult GetMascotaById(int id)
        {
            var mascota = _db.Mascota.FirstOrDefault(m => m.Id == id);
            if (mascota == null)
            {
                return NotFound();
            }
            return Ok(mascota);
        }

        [HttpPut("{id}")]
        public IActionResult EditMascota(int id, [FromBody] Mascota mascota)
        {
            var existingMascota = _db.Mascota.FirstOrDefault(m => m.Id == id);
            if (existingMascota == null)
            {
                return NotFound();
            }

            existingMascota.IdDatos = mascota.IdDatos;
            existingMascota.IdPersona = mascota.IdPersona;
            existingMascota.Inputdatovalor = mascota.Inputdatovalor;
            existingMascota.FechaIngreso = mascota.FechaIngreso;
            existingMascota.FechaActualiza = DateTime.Now;

            _db.Mascota.Update(existingMascota);
            _db.SaveChanges();

            return Ok(existingMascota);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMascota(int id)
        {
            var mascota = _db.Mascota.FirstOrDefault(m => m.Id == id);
            if (mascota == null)
            {
                return NotFound();
            }

            _db.Mascota.Remove(mascota);
            _db.SaveChanges();

            return Ok();
        }
    }
}
