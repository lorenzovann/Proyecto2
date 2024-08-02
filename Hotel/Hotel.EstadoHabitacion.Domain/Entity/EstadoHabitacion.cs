using Hotel.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.EstadoHabitacion.Domain.Entity
{
    public class EstadoHabitacion : BaseEntity<int>
    {
        [Column("IdEstadoHabitacion")] 
        public override int Id { get; set; }

        public string? Descripcion { get; set; }
        
        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        
    }
}
