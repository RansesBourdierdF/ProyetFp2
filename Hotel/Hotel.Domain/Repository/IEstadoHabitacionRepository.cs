using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Hotel.Domain.Entities;

namespace Hotel.Domain.Repository
{
	public interface IEstadoHabitacionRepository
	{
        void Save(EstadoHabitacion estadoHabitacion);

        void Update(EstadoHabitacion estadoHabitacion);

        void Remove(EstadoHabitacion estadoHabitacion);

        List<EstadoHabitacion> GetEstadoHabitacions();

        EstadoHabitacion GetEstadoHabitacion(int Id);

        bool Exists(Expression<Func<EstadoHabitacion, bool>> filter);
    }
}

