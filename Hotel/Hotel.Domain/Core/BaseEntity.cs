using System;

namespace Hotel.Domain.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity(int creacionDeUsuario)
        {
            CreacionDeUsuario = creacionDeUsuario;
        }

        public DateTime FechaCreacion { get; set; }
        public int CreacionDeUsuario { get; set; }
        public DateTime? ModificarFecha { get; set; }
        public int? UsuarioMod { get; set; }
        public int? EliminacionDeUsuario { get; set; }
        public DateTime? FechaDeEliminacion { get; set; }
        public bool Eliminar { get; set; }
        public int IdCliente { get; set; }
      
    }
}
