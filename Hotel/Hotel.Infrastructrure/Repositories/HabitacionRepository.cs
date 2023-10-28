using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Context;
using Hotel.Infrastructrure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Infrastructrure.Repositories
{
    public class HabitacionRepository : BaseRepository<Habitacion>, IHabitacionRepository
    {
        List<Habitacion> IHabitacionRepository.GetHabitacion()
        {
            throw new NotImplementedException();
        }

        Habitacion IHabitacionRepository.GetHabitacion(int id)
        {
            throw new NotImplementedException();
        }

        void IHabitacionRepository.Remove(Habitacion Habitacion)
        {
            throw new NotImplementedException();
        }

        void IHabitacionRepository.Save(Habitacion Habitacion)
        {
            throw new NotImplementedException();
        }

        void IHabitacionRepository.Update(Habitacion Habitacion)
        {
            throw new NotImplementedException();
        }
    }
}