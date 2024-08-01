using Hotel.EstadoHabitacion.Application.core;
using Hotel.EstadoHabitacion.Application.Dto;

namespace Hotel.EstadoHabitacion.Application.Interface
{
    public interface IEstadoHabitacionService 
    {
        ServiceResult GetEstadoHabitacion();
        ServiceResult GetEstadoHabitacionById(int id);
        ServiceResult SaveEstadoHabitacion(EstadoHabitacionDTOSave estadoHabitacionDTOSave);
        ServiceResult RemoveEstadoHabitacion(EstadoHabitacionDTORemove estadoHabitacionDTORemove);
        ServiceResult UpdateEstadoHabitacion(EstadoHabitacionDTOUpdate estadoHabitacionDTOUpdate);
        
    }
}
