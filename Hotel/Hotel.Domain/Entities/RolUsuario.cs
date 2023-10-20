using Hotel.Domain.Core;
using School.Domain.Core;
using System;

namespace Hotel.Domain.Entities
{
    public class RolUsuario : Person
    {
        public int RolUsuarioId { get; set;}
        public string? Descripcion {  get; set;}
        public bool? Estado { get; set;}
        public DateTime? FechaCreacion { get; set;}
        public bool Delited { get; set; }
    }
}
