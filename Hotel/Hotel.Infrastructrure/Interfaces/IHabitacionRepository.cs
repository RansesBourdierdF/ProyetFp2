using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using System.Collections.Generic;

namespace Hotel.Infrastructrure.Interfaces
{
    public interface IHabitacionRepository : IBaseRepository<Habitacion>
    {
        List<Habitacion> GetHabitacionId(int HabitacionId);
    }
}