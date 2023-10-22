



using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Context;
using Hotel.Infrastructrure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Infrastructrure.Repositories
{
    public class RolRepository : BaseRepository<RolUsuario>, IRolRepository
    {
        private readonly HotelContext context;

        public RolRepository(HotelContext context) : base(context)
        {
            this.context = context;
        }

        public RolUsuario GetRolUsuario(int rolUsuario)
        {
            throw new System.NotImplementedException();
        }

        public object GetRolUsuarioById(int rolUsuarioId)
        {
            throw new NotImplementedException();
        }

        public List<RolUsuario> GetRolUsuarioByrolUsuarioId(int rolUsuario)
        {
            return this.context.RolUsuarios.Where(cd => cd.RolUsuarioId == rolUsuario
                           ).ToList();
        }

        public List<RolUsuario> GetRolUsuarios()
        {
            return this.GetEntities().Where(go => !go.Deleted).ToList();
        }

        private IEnumerable<RolUsuario> GetEntities()
        {
            throw new NotImplementedException();
        }

        object IRolRepository.GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
