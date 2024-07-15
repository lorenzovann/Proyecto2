
using Hotel.Common.Data.Repository;
using Hotel.Habitacion.Domain.Entity;

namespace Hotel.Habitacion.Domain.Interface
{
    public interface IHabitacionRepository : IBaseRepository<Habitacion.Domain.Entity.Habitacion, int>
    {
        List<Habitacion.Domain.Entity.Habitacion> GetHabitacionById(int id);
    }
}
