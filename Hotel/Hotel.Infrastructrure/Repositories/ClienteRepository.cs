using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Hotel.Infrastructrure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSpecial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Exists(Expression<Func<Cliente, bool>> filter)
        {
            
            bool exists = true; // Supongamos que el cliente existe
            if (!exists)
            {
                throw new ClienteNotFoundException("El cliente no se encontró en la base de datos.");
            }
            return exists;
        }
        public List<Cliente> FindAll(Expression<Func<Cliente, bool>> filter)
        {
          
            List<Cliente> clientes = new List<Cliente>(); // Supongamos que obtienes los clientes correctamente.
            return clientes;
        }

        public Cliente Get(int id)
        {
            Cliente? cliente = null; // Supongamos que obtienes el cliente correctamente.
            if (cliente == null)
            {
                throw new ClienteNotFoundException("El cliente con el ID especificado no se encontró.");
            }

            return cliente;
        }

        public List<Cliente> GetEntities()
        {
            
            List<Cliente> clientes = new List<Cliente>(); // Supongamos que obtienes los clientes correctamente.
            return clientes;
        }

        public Cliente GetEntity(int Id)
        {
            
            Cliente? cliente = null; // Supongamos que obtienes la entidad Cliente correctamente.
            if (cliente == null)
            {
                throw new ClienteNotFoundException("La entidad Cliente con el ID especificado no se encontró.");
            }
            return cliente;
        }

        public void Remove(Cliente entity)
        {
            // Implementa la lógica para eliminar un cliente de la base de datos.
        }

        public void Save(Cliente entity)
        {
            // Implementa la lógica para guardar un nuevo cliente en la base de datos.
        }

        public void Update(Cliente entity)
        {
            // Implementa la lógica para actualizar un cliente en la base de datos.
        }

        [Serializable]
        private class ClienteNotFoundException : Exception
        {
            public ClienteNotFoundException()
            {
            }

            public ClienteNotFoundException(string message) : base(message)
            {
            }

            public ClienteNotFoundException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected ClienteNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}