using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using System.Collections.Generic;

namespace Hotel.Infrastructrure.Interfaces
{
    public interface IRolRepository : IBaseRepository<RolUsuario>
    {
        List<RolUsuario> GetRolUsuarios(int id);


    }
}
