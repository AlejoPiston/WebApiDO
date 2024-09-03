using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiDO.DATABDD.DTO
{
    public class DatosFormu_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Datos { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_actulizacion { get; set; }
    }
}
