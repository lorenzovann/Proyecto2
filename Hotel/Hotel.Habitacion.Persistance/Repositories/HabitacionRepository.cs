using Hotel.Habitacion.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Habitacion.Persistance.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        public bool Exist(Expression<Func<Domain.Entity.Habitacion, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entity.Habitacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entity.Habitacion GetEntityBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entity.Habitacion> GetHabitacionById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Entity.Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entity.Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entity.Habitacion entity)
        {
            throw new NotImplementedException();
        }
    }
}
