using Hotel.EstadoHabitacion.Domain.Interface;
using System.Linq.Expressions;


namespace Hotel.EstadoHabitacion.Persistance.Repositories
{
    public class EstadoHabitacionRepository : IEstadoHabitacionRepository
    {
        public bool Exist(Expression<Func<Domain.Entity.EstadoHabitacion, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entity.EstadoHabitacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entity.EstadoHabitacion GetEntityBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entity.EstadoHabitacion> GetEstadoHabitacionById(int idestadohabitacion)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Entity.EstadoHabitacion entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entity.EstadoHabitacion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entity.EstadoHabitacion entity)
        {
            throw new NotImplementedException();
        }
    }
}
