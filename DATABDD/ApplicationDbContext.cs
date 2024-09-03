using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using WebApiDO.DATABDD;
using DATABDD.DATADB;

namespace WebApiDO.DATABDD
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DatosFormu> datos { get; set; }
        public DbSet<Persona> personas { get; set; }
        public DbSet<Mascota> mascotas { get; set; }
        public DbSet<Boton> botones { get; set; }
    }
}
