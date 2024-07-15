using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Habitacion.Application.Core
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
