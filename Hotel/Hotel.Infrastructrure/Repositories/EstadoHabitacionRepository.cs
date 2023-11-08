using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Context;
using Hotel.Infrastructrure.Interfaces;

namespace Hotel.Infrastructrure.Repositories
{
    public class EstadoHabitacionRepository : IEstadoHabitacionRepository
    {
        private readonly HotelContext context;

        public EstadoHabitacionRepository(HotelContext context)
        {
            this.context = context;
        }

        public bool Exists(Expression<Func<EstadoHabitacion, bool>> filter)
        {
            return this.context.EstadoHabitacions.Any(filter);
        }

        public List<EstadoHabitacion> GetEntities()
        {
            return this.context.EstadoHabitacions.Where(st => !st.Deleted).ToList();
        }

        public EstadoHabitacion GetEntity(int Id)
        {
            return this.context.EstadoHabitacions.Find(Id);
        }

        public List<EstadoHabitacion> GetEstadoHabitacionId(int estadoHabitacionId)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(EstadoHabitacion entity)
        {
            this.context.EstadoHabitacions.Remove(entity);
        }

        public void Save(EstadoHabitacion entity)
        {
            this.context.EstadoHabitacions.Add(entity);
        }

        public void Update(EstadoHabitacion entity)
        {
            this.context.EstadoHabitacions.Update(entity);
        }
    }
}


