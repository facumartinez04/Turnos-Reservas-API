using System;
using System.Collections.Generic;

namespace DLL;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public decimal Duracion { get; set; }

    public string? Imagen { get; set; }
}
