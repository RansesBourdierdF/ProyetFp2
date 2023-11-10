using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Context;
using Hotel.Infrastructrure.Core;
using Hotel.Infrastructrure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hotel.Infrastructrure.Repositories
{
    public class HabitacionRepository : BaseRepository<Habitacion>, IHabitacionRepository
    {
        private readonly HotelContext context;

        public HabitacionRepository(HotelContext context) : base(context)
        {
            this.context = context;
        }

        public bool Exists(Expression<Func<Habitacion, bool>> filter)
        {
            return this.context.Habitacions.Any(filter);
        }

        public List<Habitacion> GetEntities()
        {
            return this.context.Habitacions.Where(st => !st.Deleted).ToList();
        }

        public Habitacion GetEntity(int Id)
        {
            return this.context.Habitacions.Find(Id);
        }

        public List<Habitacion> GetHabitacionId(int HabitacionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Habitacion> GetHabitacions()
        {
            throw new NotImplementedException();
        }

        public dynamic GetHabitacions(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Habitacion entity)
        {
          this.context.Habitacions.Remove(entity);

        }

        public void Save(Habitacion entity)
        {
            this.context.Habitacions.Add(entity);
        }

        public void Update(Habitacion entity)
        {
            this.context.Habitacions.Update(entity);
        }
    }
}