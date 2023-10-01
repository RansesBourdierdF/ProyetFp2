using System;
using Hotel.Domain.Core;

namespace Hotel.Domain.Entities
{
    public class EstadoHabitacion : BaseEntity
    {
        public int IdEstadoHabitacion { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}

