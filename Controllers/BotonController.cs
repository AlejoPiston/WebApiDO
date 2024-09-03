using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WebApiDO.DATABDD;
using WebApiDO.DATABDD.DTO;
using WebApiDO.DATABDD;
using DATABDD.DATADB;

namespace DATABDD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotonController : ControllerBase
    {
        private readonly ILogger<BotonController> _logger;
        private readonly ApplicationDbContext _db;

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            var botons = _db.botones.ToList();
            return Ok(botons);
        }

        

    }
}
