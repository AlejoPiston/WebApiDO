using System;
using System.Collections.Generic;

namespace WebApiDO.DATABDD;

public partial class Boton
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaActualiza { get; set; }
}
