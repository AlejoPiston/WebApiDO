using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DATABDD.DATADB
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int idDato { get; set; }
        public string inputdatovalor { get; set; }
        public DatosFormu datos { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_actulizacion { get; set; }
    }
}
