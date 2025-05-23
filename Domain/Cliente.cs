﻿using System;
using System.Collections.Generic;

namespace DLL;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int IdTipoIdentificacion { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string? Direccion { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Email { get; set; }



}
