using System.Collections.Generic;
using Hotel.Domain.Entities;
using Hotel.Domain.Repository;

namespace Hotel.Infrastructrure.Interfaces
{
    public interface IEstadoHabitacionRepository : IBaseRepository<EstadoHabitacion>
    {
        List<EstadoHabitacion> GetEstadoHabitacionId(int estadoHabitacionId);
    }
}