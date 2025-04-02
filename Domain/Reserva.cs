using System;
using System.Collections.Generic;

namespace DLL;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int IdCliente { get; set; }

    public DateTime FechaReserva { get; set; }

    public DateTime Horario { get; set; }

    public decimal PrecioTotal { get; set; }

    public int IdDetalleServicios { get; set; }
}
