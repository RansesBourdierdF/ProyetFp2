using Hotel.Domain.Core;
using School.Domain.Core;
using System;


namespace Hotel.Domain.Entities
{
    public class Usuario : Person
    {
       
        public int IdUsuario { get; set; }

        
        public string? NombreCompleto { get; set; }

        
        public string? Correo { get; set; }

        public int? IdRolUsuario { get; set; }

        
        public string? Clave { get; set; }

        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }
    }
}
