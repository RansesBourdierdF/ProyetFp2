

using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Context;
using Hotel.Infrastructrure.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;

namespace Hotel.Infrastructrure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario> , IUsuarioRepository
    {
        private readonly HotelContext context;

        public UsuarioRepository(HotelContext context) : base(context) 
        {
            this.context = context;
        }
        public List<Usuario> GetUsuariosByusuarioId(int usuarioId)
        {
          

            return this.context.Usuarios.Where(dc => dc.IdUsuario == usuarioId ).ToList();
                                                        
        }

        public List<Usuario> GetUsuarios ()
        {
            return this.GetEntities().Where(go => !go.Deleted).ToList();

        }

        public List<Usuario> GetUsuario()
        {
            throw new System.NotImplementedException();
        }

        public Usuario GetUsuario(int id)
        {
            throw new System.NotImplementedException();
        }

        public object GetUsuarioById(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
