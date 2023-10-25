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
        public object GetCategoriaById(int categoriaId)
        {
            throw new NotImplementedException();
        }

        public Cliente GetCliente(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetClientes()
        {
            throw new NotImplementedException();
        }

        // ... otros métodos

        public List<Categoria> GetEntities()
        {
            List<Categoria> categorias = new List<Categoria>(); // Supongamos que obtienes las categorías correctamente.
            return categorias;
        }

        public void Remove(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        // ... otros métodos

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        [Serializable]
        private class CategoriaNotFoundException : Exception
        {
            public CategoriaNotFoundException()
            {
            }

            public CategoriaNotFoundException(string message) : base(message)
            {
            }

            public CategoriaNotFoundException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected CategoriaNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
