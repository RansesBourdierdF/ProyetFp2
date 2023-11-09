
using System;
using School.Application.Dtos.Base;

namespace Hotel.Application.Dtos.EstadoHabitacion
{
    public class EstadoHabitacionDtoBase : DtoBase
    {
        public int IdEstadoHabitacion { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public new bool? Estado { get; set; }

    }
}

