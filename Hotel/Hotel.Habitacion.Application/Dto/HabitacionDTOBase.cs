using System;
using System.Collections.Generic;
using System.Linq;


namespace Hotel.Habitacion.Application.Dto
{
    public class HabitacionDTOBase
    {
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public string Detalle { get; set; }
        public int Precio { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; }

    }

   
}
