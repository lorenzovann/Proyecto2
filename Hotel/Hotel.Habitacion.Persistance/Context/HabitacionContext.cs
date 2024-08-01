using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Habitacion.Persistance.Context
{
    public class HabitacionContext : DbContext
    {
        public HabitacionContext(DbContextOptions<HabitacionContext> options) : base(options) 
        { 

        }

        public DbSet<Habitacion.Domain.Entity.Habitacion> Habitacions { get; set; }
    }
}
