using System;
using System.Collections.Generic;

namespace DLL;

public partial class TipoIdentificacion
{
    public int IdTipoIdentificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}
