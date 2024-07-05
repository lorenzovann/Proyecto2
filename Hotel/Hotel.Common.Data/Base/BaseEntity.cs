

using System.Security.Cryptography.X509Certificates;

namespace Hotel.Common.Data.Base
{
    public abstract class BaseEntity
    {
        protected BaseEntity() 
        {
            this.FechaCreacion = DateTime.Now;
            this.Delete = false;
        
        }

        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public bool Delete { get; set; }
    }
}
