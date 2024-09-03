using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using WebApiDO.DATABDD;
using DATABDD.DATADB;

namespace WebApiDO.DATABDD.DTO
{
    public class Mascota_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int idDatos { get; set; }
        public int id_persona { get; set; }
        public string inputdatovalor { get; set; }
        public DatosFormu Datos { get; set; }
        public Persona Person { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_actualiza { get; set; }
    }
}
