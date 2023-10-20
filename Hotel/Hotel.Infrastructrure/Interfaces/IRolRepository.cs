using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using System.Collections.Generic;
using System.Data;

namespace Hotel.Infrastructrure.Interfaces
{
    public interface IRolRepository : IBaseRepository<RolUsuario>
    {
        object GetRolUsuarioById(int rolUsuarioId);
        public List<RolUsuario> GetRolUsuarioByrolUsuarioId(int rolUsuarioId);

    }
}
