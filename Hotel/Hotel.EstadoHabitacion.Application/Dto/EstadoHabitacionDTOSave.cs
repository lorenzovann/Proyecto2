using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EstadoHabitacion.Application.Dto
{
    public class EstadoHabitacionDTOSave : EstadoHabitacionDTOBase
    {
        public string? Descripcion { get; set; }

        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }

    }
}
