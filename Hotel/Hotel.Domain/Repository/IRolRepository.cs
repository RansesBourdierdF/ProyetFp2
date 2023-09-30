using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Repository
{
    public interface IRolRepository
    {
        void Save(RolUsuario rolUsuario);
        void Remove(RolUsuario rolUsuario);
        List<RolUsuario> GetRolUsuarios();
        RolUsuario GetRolUsuario(int id);



    }
}
