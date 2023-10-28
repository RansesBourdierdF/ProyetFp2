using System;
using System.Collections.Generic;
using Hotel.Domain.Entities;

namespace Hotel.Domain.Repository
{

    public interface IEstadoHabitacionRepository
    {

        void Save(EstadoHabitacion estadoHabitacion);
        void Update(EstadoHabitacion estadoHabitacion);
        void Remove(EstadoHabitacion estadoHabitacion);
        List<EstadoHabitacion> GetEstadoHabitacion();
        EstadoHabitacion GetEstadoHabitacion(int id);

    }
}

