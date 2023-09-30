using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Repository
{
    public interface IUsuarioRepository
    {

        void save(Usuario usuario);
        void Remove(Usuario usuario);
        List<Usuario> GetUsuario();
        Usuario GetUsuario(int id);


    }
}
