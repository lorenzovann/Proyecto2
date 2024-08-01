using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EstadoHabitacion.Persistance.Exceptions
{
    public class EstadoHabitacionException : Exception
    {
        
        
            public EstadoHabitacionException(string message) : base(message)
            {
            }

            public EstadoHabitacionException(string? message, Exception? innerException) : base(message, innerException)
            {
            }
        
    }
}
