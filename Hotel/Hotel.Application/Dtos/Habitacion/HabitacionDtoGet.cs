using System;
namespace Hotel.Application.Dtos.EstadoHabitacion
{
    public class HabitacionDtoGet
    {

        public int IdHabitacion { get; set; }

        public string? Numero { get; set; }

        public string? Detalle { get; set; }

        public decimal? Precio { get; set; }

        public int? IdestadoHabitacion { get; set; }

        public int? IdPiso { get; set; }

        public int? IdCategoria { get; set; }

        public new bool? Estado { get; set; }

    }
}

