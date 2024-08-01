using Hotel.EstadoHabitacion.Application.Interface;
using Hotel.EstadoHabitacion.Application.Service;
using Hotel.EstadoHabitacion.Domain.Interface;
using Hotel.EstadoHabitacion.Persistance.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EstadoHabitacion.IOC.Dependency
{
    public static class EstadoHabitacionDependency
    {
        public static void AddEstadoHabitacionDependency(this IServiceCollection services)
        {
            #region "Repositories"
            
            services.AddScoped<IEstadoHabitacionRepository, EstadoHabitacionRepository>();

            #endregion

            #region "Services"
            services.AddTransient<IEstadoHabitacionService, EstadoHabitacionService>();
            #endregion
        }
        
    }
}
