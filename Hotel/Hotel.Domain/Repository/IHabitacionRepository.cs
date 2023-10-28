using System;
using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel.Domain.Repository
{
    public interface IHabitacionRepository
    {
        void Save(Habitacion Habitacion);
        void Update(Habitacion Habitacion);
        void Remove(Habitacion Habitacion);
        List<Habitacion> GetHabitacion();
        Habitacion GetHabitacion(int id);

    }
}


