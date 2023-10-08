using Hotel.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Repository
{
    public interface ICategoriaRepository
    {

        void Save(Cliente cliente);
        void Remove(Cliente cliente);
        List<Cliente> GetClientes();
        Cliente GetCliente(int id);


    }
}


