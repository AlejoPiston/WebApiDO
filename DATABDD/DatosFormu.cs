using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATABDD.DATADB
{
    public class DatosFormu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Datos { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_actulizacion {  get; set; }
    }
}
