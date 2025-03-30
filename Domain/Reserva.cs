namespace Domain
{
    public class Reserva
    {

        public int idReserva { get; set; }

        public Cliente objCliente { get; set; }
        public DateOnly fechaInicio { get; set; }

        public DateTime horario { get; set; }
        public decimal precioTotal { get; set; }

        public List<Servicio> objServicios { get; set; }


    }
}
