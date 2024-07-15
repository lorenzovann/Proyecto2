using Microsoft.EntityFrameworkCore;
using Hotel.EstadoHabitacion.Domain.Entity;

namespace Hotel.EstadoHabitacion.Persistance.Context
{
    public class HotelContext : DbContext
    {
        #region "Constructor"
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
        #endregion


        #region "Db Sets"

        public DbSet<Domain.Entity.EstadoHabitacion> EstadoHabitacion { get; set; }
        //public DbSet<Habitacion.> Habitacion { get; set; }

        #endregion

    }
}
