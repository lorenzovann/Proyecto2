using Hotel.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.EstadoHabitacion.Domain.Entity
{
    public class EstadoHabitacion : AuditEntity<int>
    {
        [Column("IdEstadoHabitacion")] 
        public override int Id { get; set; }
    }
}
