using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EstadoHabitacion.Persistance.CRUD
{
    public abstract class EstadoHabitacionBaseModel
    {
        public int IdEstadoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
