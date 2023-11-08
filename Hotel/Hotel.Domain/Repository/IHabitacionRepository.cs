using System;
using Hotel.Domain.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Hotel.Domain.Repository
{
	public interface IHabitacionRepository
	{
        void Save(Habitacion habitacion);

        void Update(Habitacion habitacion);

        void Remove(Habitacion habitacion);

        List<Habitacion> GetHabitacions();

        Habitacion GetHabitacion(int Id);

        bool Exists(Expression<Func<Habitacion, bool>> filter);
    }
}

