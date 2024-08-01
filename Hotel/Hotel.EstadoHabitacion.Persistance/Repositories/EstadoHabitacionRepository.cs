using Hotel.EstadoHabitacion.Domain.Interface;
using Hotel.EstadoHabitacion.Persistance.Context;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

 
namespace Hotel.EstadoHabitacion.Persistance.Repositories
{
    public class EstadoHabitacionRepository : IEstadoHabitacionRepository
    {
        private readonly EstadoHabitacionContext _EstadoHabitacionContext;
        private readonly ILogger<EstadoHabitacionRepository> _logger;

        public EstadoHabitacionRepository(EstadoHabitacionContext context, ILogger<EstadoHabitacionRepository> logger)
        {
            _EstadoHabitacionContext = context;
            _logger = logger;
        }

        public bool Exist(Expression<Func<Domain.Entity.EstadoHabitacion, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entity.EstadoHabitacion> GetAll()
        {
            if (_EstadoHabitacionContext == null)
            {
                _logger.LogError("EstadoHabitacion esta null");
                return new List<Domain.Entity.EstadoHabitacion>();

            }

            return _EstadoHabitacionContext.EstadoHabitacion.ToList();
        }   

        public Domain.Entity.EstadoHabitacion GetEntityBy(int id)
        {
            try
            {
                var estadohabitacion = _EstadoHabitacionContext.EstadoHabitacion.Find(id);
                if (estadohabitacion is null)
                {
                    _logger.LogError($"EstadoHabitacion con: {id} no se encontro");
                    return null;

                }

                return estadohabitacion;
            }

            catch
            {
                this._logger.LogError($"error al tratar de encontrar EstadoHabitacion por el id: {id}");
                throw;

            }
        }

        

        public void Remove(Domain.Entity.EstadoHabitacion entity)
        {
            try 
            { 
                if (entity is null) 
                {
                    _logger.LogError("Entity n");
                    return;
                }

                var estadohabitacionEliminar = this._EstadoHabitacionContext.EstadoHabitacion.Find(entity.Id);

                if (estadohabitacionEliminar is null) 
                {
                  
                    _logger.LogError($"EstadoHabitacion con el id: {entity.Id} no se pudo encontrar");
                
                }

                _EstadoHabitacionContext.EstadoHabitacion.Remove(estadohabitacionEliminar);
                _EstadoHabitacionContext.SaveChanges(); 
            }
            catch(Exception ex) 
            { 
                _logger.LogError($"Error tratando de eliminar EstadoHabitacion con id: {entity.Id}");
                throw;
            }
        }

        public void Save(Domain.Entity.EstadoHabitacion entity)
        {
            try
            {
                if (entity is null)
                {
                    _logger.LogError($"Entity no puede ser null");
                    return;
                }

                _EstadoHabitacionContext.EstadoHabitacion.Add(entity);
                _EstadoHabitacionContext.SaveChanges();


            }

            catch
            {
                
                _logger.LogError($"Error tratando de guardar EstadoHabitacion con el id: {entity.Id} ");

            }
            
        }

        public void Update(Domain.Entity.EstadoHabitacion entity)
        {
            try
            {
                if (entity is null)
                {
                    _logger.LogError($"Entity no puede ser null");
                    return;
                }


                var estadohabitacionActualizar = this._EstadoHabitacionContext.EstadoHabitacion.Find(entity.Id);

                if (estadohabitacionActualizar is null)
                {
                    _logger.LogError($"Error al actualizar EstadoHabitacion con el id{entity.Id}"); 
                    return;

                }

                estadohabitacionActualizar.Id = entity.Id;
                estadohabitacionActualizar.IdEstadoHabitacion = entity.IdEstadoHabitacion;
                estadohabitacionActualizar.Estado = entity.Estado;
                estadohabitacionActualizar.Descripcion = entity.Descripcion;

                _EstadoHabitacionContext.Entry(estadohabitacionActualizar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                _EstadoHabitacionContext.SaveChanges();
            }

            catch
            {
                _logger.LogError($"Error al tratar de actualizar EstadoHabitacion con el id: {entity.Id}"); 
                throw;

            }


        }


       
    }
}
