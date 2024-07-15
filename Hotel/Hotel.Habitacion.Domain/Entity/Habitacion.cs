using Hotel.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Habitacion.Domain.Entity
{
    public class Habitacion : AuditEntity<int>
    {
        [Column("IdHabitacion")]
        public override int Id { get; set; }
    }
}
