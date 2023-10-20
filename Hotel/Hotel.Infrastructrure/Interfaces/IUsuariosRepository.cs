using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using System.Collections.Generic;

namespace Hotel.Infrastructrure.Interfaces
{
    public interface IUsuariosRepository : IBaseRepository<Usuario>
    {
        public List<Usuario> GetUsuariosByusuarioId(int usuarioId);
        
    }
}
