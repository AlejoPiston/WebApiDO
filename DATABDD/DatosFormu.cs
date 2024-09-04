using System;
using System.Collections.Generic;

namespace WebApiDO.DATABDD;

public partial class DatosFormu
{
    public int Id { get; set; }

    public string Datos { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaActulizacion { get; set; }

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
