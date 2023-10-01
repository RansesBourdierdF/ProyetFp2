using System;
using System.Collections.Generic;
using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Interfaces;

namespace Hotel.Infrastructrure.Repositories
{
    public class EstadoHabitacionRepository : IEstadoHabitacionRepository
    {
        List<EstadoHabitacion> IBaseRepository<EstadoHabitacion>.GetEntities()
        {
            throw new NotImplementedException();
        }

        EstadoHabitacion IBaseRepository<EstadoHabitacion>.GetEntity(int Id)
        {
            throw new NotImplementedException();
        }

        List<EstadoHabitacion> IEstadoHabitacionRepository.GetEstadoHabitacion(int HabitacionId)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<EstadoHabitacion>.Remove(EstadoHabitacion entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<EstadoHabitacion>.Save(EstadoHabitacion entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<EstadoHabitacion>.Update(EstadoHabitacion entity)
        {
            throw new NotImplementedException();
        }
    }
}


