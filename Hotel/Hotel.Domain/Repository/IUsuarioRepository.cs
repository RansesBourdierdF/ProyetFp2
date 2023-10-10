using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel.Domain.Repository
{
    public interface IUsuarioRepository
    {

        void Save(Usuario usuario);
        void Update(Usuario usuario);
        void Remove(Usuario usuario);
        List<Usuario> GetUsuario();
        Usuario GetUsuario(int id);


    }
}