using System;
using School.Application.Dtos.Base;

namespace Hotel.Application.Dtos.EstadoHabitacion
{
	public class EstadoHabitacionDtoRemove : DtoBase
	{

		
			public int EstadoHabitacionId { get; set; }
			public bool Deleted { get; set; }
		
	}
}

