using System;
using Hotel.Domain.Core;

namespace Hotel.Domain.Entities
{
    public class Habitacion : BaseEntity
    {
        public int IdHabitacion { get; set; }
        public string? Numero { get; set; }
        public string? Detalle { get; set; }
        public decimal? Precio { get; set; }
        public new int? IdEstadoHabitacion { get; set; }
        public int? IdPiso { get; set; }
        public int? IdCategoria { get; set; }
        public new bool? Estado { get; set; }

    }
}