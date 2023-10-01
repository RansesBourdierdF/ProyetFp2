using System;
using System.Collections.Generic;
using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Interfaces;

namespace Hotel.Infrastructrure.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        List<Habitacion> IHabitacionRepository.GetHabitacion(int HabitacionId)
        {
            throw new NotImplementedException();
        }
    }
}