﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cliente
    {
        public int idCliente { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public TipoIdentificacion objTipoIdentificacion { get; set; }

        public DateOnly fechaNacimiento { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string email { get; set; }


    }
}
