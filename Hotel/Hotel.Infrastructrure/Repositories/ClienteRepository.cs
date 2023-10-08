using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Hotel.Infrastructrure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public bool Exists(Expression<Func<Cliente, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> FindAll(Expression<Func<Cliente, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Cliente Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Cliente GetEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}