using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Common.Data.Base
{
    public abstract class AuditEntity<TType> : BaseEntity<TType>
    {
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; } 
    }
}
