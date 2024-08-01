using Hotel.EstadoHabitacion.Application.core;
using Hotel.EstadoHabitacion.Application.Dto;
using Hotel.EstadoHabitacion.Application.Interface;

using Hotel.EstadoHabitacion.Domain.Interface;
using Microsoft.Extensions.Logging;


namespace Hotel.EstadoHabitacion.Application.Service
{
    public class EstadoHabitacionService : IEstadoHabitacionService
    {
        private readonly IEstadoHabitacionRepository _estadoHabitacionRepository;
        private readonly ILogger<EstadoHabitacionService> _logger;

        public EstadoHabitacionService(IEstadoHabitacionRepository estadoHabitacionRepository, ILogger<EstadoHabitacionService> logger)
        {
            _estadoHabitacionRepository = estadoHabitacionRepository;
            _logger = logger;
        }

        public ServiceResult RemoveEstadoHabitacion(EstadoHabitacionDTORemove estadoHabitacionDTORemove)
        {
            var result = new ServiceResult();
            try
            {
                var estadohabitacionEliminar = _estadoHabitacionRepository.GetEntityBy(estadoHabitacionDTORemove.IdEstadoHabitacion);
                _estadoHabitacionRepository.Remove(estadohabitacionEliminar);
                result.Success = true;
                result.Message = "EstadoHabitacion borrado";
                return result;

            }
            catch (System.Exception ex) 
            { 
               _logger.LogError(ex, "Error en DeleteEstadoHabitacion");
                result.Success = false;
                result.Message = "Error en DeleteEstadoHabitacion";
                return result;  

            }
        }

        public ServiceResult GetEstadoHabitacion()
        {
            var result = new ServiceResult();
            try
            {
                var estadoHabitacion = _estadoHabitacionRepository.GetAll();
                if (estadoHabitacion == null)
                {
                    result.Success = false;
                    result.Message = "Asiento not found";
                }
                result.Result = estadoHabitacion;
                result.Success = true;
                return result;
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error en IdEstadoHabitacion");
                result.Success = false;
                result.Message = "Error in IdEstadoHabitacion";
                return result;
            }
        }

            public ServiceResult GetEstadoHabitacionById(int id)
            {
                var result = new ServiceResult();
                try
                {
                    var estadohabitacion = _estadoHabitacionRepository.GetEntityBy(id);
                    if (estadohabitacion == null)
                    {
                        result.Success = false;
                        result.Message = "EstadoHabitacion no encontrado";

                    }
                    result.Result=estadohabitacion;
                    result.Success = true;
                    return result;
                }
                catch (System.Exception ex)
                {
                    _logger.LogError(ex, "Error en GetEstadoHabitacionBYId");
                    result.Success = false;
                    result.Message = "Error en GetEstadoHabitacionBYId";
                    return result;

                }

            }

            public ServiceResult SaveEstadoHabitacion(EstadoHabitacionDTOSave estadoHabitacionDTOSave)
            {
                var result = new ServiceResult();
                try
                {
                    var estadohabitacion = new Domain.Entity.EstadoHabitacion
                    {
                        IdEstadoHabitacion = estadoHabitacionDTOSave.IdEstadoHabitacion,
                        Descripcion = estadoHabitacionDTOSave.Descripcion,
                        Estado = estadoHabitacionDTOSave.Estado,

                    };

                    _estadoHabitacionRepository.Save(estadohabitacion);
                    result.Success = true;
                    result.Message = " EstadoHabitacion guardado";
                    return result;


                }

                catch (System.Exception ex)
                {
                    _logger.LogError(ex, "Error en SaveEstadoHabitacion");
                    result.Success = false;
                    result.Message = "Error en SaveEstadoHabitacion";
                    return result;


                }
            }

            public ServiceResult UpdateEstadoHabitacion(EstadoHabitacionDTOUpdate estadoHabitacionDTOUpdate)
            {
                var result = new ServiceResult();
                try
                {
                    var estadohabitacion = new Domain.Entity.EstadoHabitacion
                    {
                        IdEstadoHabitacion = estadoHabitacionDTOUpdate.IdEstadoHabitacion,
                        Descripcion = estadoHabitacionDTOUpdate.Descripcion,
                        Estado = estadoHabitacionDTOUpdate.Estado,

                    };
                    _estadoHabitacionRepository.Update(estadohabitacion);
                    result.Success = true;
                    result.Message = "EstadoHabitacion Actualizado";
                    return result;

                }
                catch (System.Exception ex)
                {
                    _logger.LogError(ex, "Error en UpdateEstadoHabitacion");
                    result.Success = false;
                    result.Message = "Error en UpdateEstadoHabitacion";
                    return result;


                }

            }

       
    }

       
}
