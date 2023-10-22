﻿using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Infrastructrure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly HotelContext context;
        private readonly DbSet<TEntity> entities;

        public  BaseRepository(HotelContext context)
        {
            this.context = context;
            this.entities = context.Set<TEntity>();
        }

        public BaseRepository(HotelContext context, DbSet<TEntity> entities)
        {
            this.context = context;
            this.entities = entities;
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            return this.entities.Any(filter);
        }

        public virtual List<TEntity> FindAll(Expression<Func<TEntity, bool>> filter)
        {
            return this.entities.Where(filter).ToList();
        }

        public virtual List<TEntity> GetEntities(int id)
        {
            return this.entities.ToList();
        }

        public List<TEntity> GetEntities()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity GetEntity(int Id)
        {
            return this.entities.ToList()[Id];
        }

        public virtual void Remove(TEntity entity)
        {
            this.entities.Remove(entity);
        }

        public virtual void Save(TEntity entity)
        {
            this.entities.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            this.entities.Update(entity);

        }

    }

}



