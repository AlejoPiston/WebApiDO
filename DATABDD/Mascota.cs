using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DATABDD.DATADB
{
    public class Mascota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int idDato { get; set; }
        public int idPerson { get; set; }
        public string inputdatovalor { get; set; }
        public DatosFormu Datos { get; set; }
        public Persona Persona { get; set; }
        public DateTime fechaingreso { get; set; }
        public DateTime fechaactulizacion { get; set; }
    }
}
