using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DATABDD.DATADB
{
    public class Boton
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Nombre { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_actulizacion { get; set; }
    }
}
