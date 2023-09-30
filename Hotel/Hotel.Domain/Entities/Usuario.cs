using School.Domain.Core;
using System;


namespace Hotel.Domain.Entities
{
    public class Usuario : RolUsuario
    {
       
        public int IdUsuario { get; set; }

        
        public string? NombreCompleto { get; set; }

        
        public string? Correo { get; set; }

        public int? IdRolUsuario { get; set; }

        
        public string? Clave { get; set; }

        public new bool? Estado { get; set; }

        public new DateTime? FechaCreacion { get; set; }
    }
}
