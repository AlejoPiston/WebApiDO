using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WebApiDO.DATABDD;

namespace DATABDD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotonController : ControllerBase
    {
        private readonly ILogger<BotonController> _logger;
        private readonly ApplicationDbContext _db;
        public BotonController(ApplicationDbContext db, ILogger<BotonController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetBotones()
        {
            var botons = _db.Botons.ToList();
            return Ok(botons);
        }

        [HttpGet("{id}")]
        public IActionResult GetBotonById(int id)
        {
            var boton = _db.Botons.FirstOrDefault(b => b.Id == id);
            if (boton == null)
            {
                return NotFound();
            }
            return Ok(boton);
        }

        [HttpPut("{id}")]
        public IActionResult EditBoton(int id, [FromBody] Boton boton)
        {
            var existingBoton = _db.Botons.FirstOrDefault(b => b.Id == id);
            if (existingBoton == null)
            {
                return NotFound();
            }

            existingBoton.Nombre = boton.Nombre;
            existingBoton.FechaIngreso = boton.FechaIngreso;
            existingBoton.FechaActualiza = DateTime.Now;

            _db.Botons.Update(existingBoton);
            _db.SaveChanges();

            return Ok(existingBoton);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBoton(int id)
        {
            var boton = _db.Botons.FirstOrDefault(b => b.Id == id);
            if (boton == null)
            {
                return NotFound();
            }

            _db.Botons.Remove(boton);
            _db.SaveChanges();

            return Ok();
        }

    }
}
