using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel.Domain.Repository
{
    public interface ICategoriaRepository1
    {
        Categoria GetCategoria(int id);
        List<Categoria> GetCategorias();
        Cliente GetCliente(int id);
        List<Cliente> GetClientes();
        void Remove(Categoria categoria);
        void Save(Categoria categoria);
        
    }
}