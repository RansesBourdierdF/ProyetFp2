using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Repository
{
    public interface ICategoriaReprository
    {
        void Save(Categoria categoria);
        void Remove(Categoria categoria);   
        List<Categoria> GetCategorias();
        Categoria GetCategoria(int id);
    }
}
