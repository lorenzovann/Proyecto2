using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Common.Data.Base
{/// <summary>
/// 
/// </summary>
/// <typeparam name="TType"></typeparam>
    public abstract class AuditEntity<TType> : BaseEntity<TType> 
    {
        public int CreationUser {  get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifyDate     { get; set; }
        public int? UserMod {  get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted {  get; set; }

    }
}
