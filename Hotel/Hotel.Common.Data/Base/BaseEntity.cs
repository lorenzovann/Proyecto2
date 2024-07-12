

using System.Security.Cryptography.X509Certificates;

namespace Hotel.Common.Data.Base
{
    public abstract class BaseEntity<TType> // mantener multiples tipos 
    {
        public TType Id { get; set; }
    }
}
