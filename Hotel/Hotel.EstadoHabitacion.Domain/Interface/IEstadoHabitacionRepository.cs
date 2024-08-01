using Hotel.Common.Data.Repository;
using Hotel.EstadoHabitacion.Domain.Entity;

namespace Hotel.EstadoHabitacion.Domain.Interface
{
    public interface IEstadoHabitacionRepository : IBaseRepository<Domain.Entity.EstadoHabitacion, int>
    {
        //List<Domain.Entity.EstadoHabitacion> GetEstadoHabitacionById(int idestadohabitacion);

    }
}
     