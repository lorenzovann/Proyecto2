using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EstadoHabitacion.Application.core
{
    public class ServiceResult
    {
        public ServiceResult() 
        { 
           this.Success = true;
        }
        public bool Success { get; set; }
        public string? Message { get; set; }
        public dynamic? Result { get; set; }
    }
}
