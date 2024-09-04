using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDO.DATABDD;

namespace WebApiDO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosFormuController : ControllerBase
    {
        private readonly ILogger<DatosFormuController> _logger;
        private readonly ApplicationDbContext _db;

        public DatosFormuController(ApplicationDbContext db, ILogger<DatosFormuController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetDatosFormus()
        {
            var datosFormus = _db.DatosFormus.ToList();
            return Ok(datosFormus);
        }

        [HttpGet("{id}")]
        public IActionResult GetDatosFormuById(int id)
        {
            var datosFormu = _db.DatosFormus.FirstOrDefault(d => d.Id == id);
            if (datosFormu == null)
            {
                return NotFound();
            }
            return Ok(datosFormu);
        }

        [HttpPut("{id}")]
        public IActionResult EditDatosFormu(int id, [FromBody] DatosFormu datosFormu)
        {
            var existingDatosFormu = _db.DatosFormus.FirstOrDefault(d => d.Id == id);
            if (existingDatosFormu == null)
            {
                return NotFound();
            }

            existingDatosFormu.Datos = datosFormu.Datos;
            existingDatosFormu.FechaIngreso = datosFormu.FechaIngreso;
            existingDatosFormu.FechaActulizacion = DateTime.Now;

            _db.DatosFormus.Update(existingDatosFormu);
            _db.SaveChanges();

            return Ok(existingDatosFormu);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDatosFormu(int id)
        {
            var datosFormu = _db.DatosFormus.FirstOrDefault(d => d.Id == id);
            if (datosFormu == null)
            {
                return NotFound();
            }

            _db.DatosFormus.Remove(datosFormu);
            _db.SaveChanges();

            return Ok();
        }
    }
}
