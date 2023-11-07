using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Context;
using Hotel.Infrastructrure.Core;
using Hotel.Infrastructrure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Infrastructrure.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        public List<Habitacion> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Habitacion GetEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Habitacion> GetHabitacionId(int HabitacionId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Habitacion entity)
        {
            throw new NotImplementedException();
        }
    }
}