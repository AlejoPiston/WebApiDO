using System;
using System.Collections.Generic;

namespace WebApiDO.DATABDD;

public partial class Persona
{
    public int Id { get; set; }

    public int IdDatos { get; set; }

    public string? IdPersona { get; set; }

    public string? Inputdatovalor { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaActualiza { get; set; }

    public virtual DatosFormu IdDatosNavigation { get; set; } = null!;

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();
}
