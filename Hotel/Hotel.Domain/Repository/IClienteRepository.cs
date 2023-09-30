using Hotel.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Repository
{
    public interface IClienteRepository
    {

        void Save(Cliente Cliente);
        void Remove(Cliente Cliente);
        List<Cliente> GetClientes();
        Cliente GetCliente(int id);


    }
}