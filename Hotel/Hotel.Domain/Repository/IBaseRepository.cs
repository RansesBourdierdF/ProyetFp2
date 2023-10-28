using System;
using System.Collections.Generic;

namespace Hotel.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        List<TEntity> Entities { get; }

        TEntity GetEntity(int Id);
    }
}