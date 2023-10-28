using System;
using System.Collections.Generic;
using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Interfaces;
using IEstadoHabitacionRepository = Hotel.Domain.Repository.IEstadoHabitacionRepository;

namespace Hotel.Infrastructrure.Repositories
{
    public class EstadoHabitacionRepository : IEstadoHabitacionRepository
    {
        List<EstadoHabitacion> IEstadoHabitacionRepository.GetEstadoHabitacion()
        {
            throw new NotImplementedException();
        }

        EstadoHabitacion IEstadoHabitacionRepository.GetEstadoHabitacion(int id)
        {
            throw new NotImplementedException();
        }

        void IEstadoHabitacionRepository.Remove(EstadoHabitacion estadoHabitacion)
        {
            throw new NotImplementedException();
        }

        void IEstadoHabitacionRepository.Save(EstadoHabitacion estadoHabitacion)
        {
            throw new NotImplementedException();
        }

        void IEstadoHabitacionRepository.Update(EstadoHabitacion estadoHabitacion)
        {
            throw new NotImplementedException();
        }
    }
}


