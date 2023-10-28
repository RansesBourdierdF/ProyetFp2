using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel.Infrastructrure.Interfaces
{
    public interface IHabitacionRepository
    {
        List<Habitacion> GetHabitacion(int HabitacionId);
        List<EstadoHabitacion> Habitacion(int HabitacionId);
    }
}