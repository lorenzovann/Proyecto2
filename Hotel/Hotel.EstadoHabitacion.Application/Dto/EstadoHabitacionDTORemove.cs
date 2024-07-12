using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EstadoHabitacion.Application.Dto
{
    public class EstadoHabitacionDTORemove
    {
        public int IdEstadoHabitacion { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
