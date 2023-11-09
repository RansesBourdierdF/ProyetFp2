using System;
namespace Hotel.Application.Dtos.EstadoHabitacion
{
	public class EstadoHabitacionDtoGet
	{

        public int IdEstadoHabitacion { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public new bool? Estado { get; set; }

    }
}

