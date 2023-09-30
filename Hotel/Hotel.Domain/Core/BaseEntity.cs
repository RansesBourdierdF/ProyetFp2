using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity(DateTime? modificacionFecha)
        {
            ModificacionFecha = modificacionFecha;
        }

        public DateTime CreacionFecha { get; set; }
        public int Creacionusuario { get; set; }
        public DateTime? ModificacionFecha { get; set; }
        public int? UsuarioMod { get; set; }
        public int? EliminacionDeUsuario { get; set; }
        public DateTime? EliminacionDeFecha { get; set; }
        public bool Deleted { get; set; }
    }
}
