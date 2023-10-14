using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Hotel.Infrastructure.Repositories
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class CategoriaRepository : ICategoriaRepository
    {
        public Cliente GetCliente(int id)
        {
            // Implementa la lógica para obtener un cliente por su ID.
            // Puedes devolver el cliente encontrado o lanzar una excepción si no se encuentra.
            // Por ejemplo:
            Cliente? cliente = null; // Supongamos que obtienes el cliente correctamente.
            if (cliente == null)
            {
                throw new ClienteNotFoundException("El cliente con el ID especificado no se encontró.");
            }
            return cliente;
        }

        public List<Cliente> GetClientes()
        {
            // Implementa la lógica para obtener todos los clientes.
            // Puedes devolver una lista de clientes o una excepción si no hay clientes disponibles.
            // Por ejemplo:
            List<Cliente> clientes = new List<Cliente>(); // Supongamos que obtienes los clientes correctamente.
            return clientes;
        }

        public void Remove(Cliente cliente)
        {
            // Implementa la lógica para eliminar un cliente de la base de datos.
        }

        public void Save(Cliente cliente)
        {
            // Implementa la lógica para guardar un nuevo cliente en la base de datos.
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
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