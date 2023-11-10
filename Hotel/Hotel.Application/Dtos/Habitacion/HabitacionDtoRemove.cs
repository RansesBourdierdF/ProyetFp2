using System;
using School.Application.Dtos.Base;

namespace Hotel.Application.Dtos.Habitacion
{
    public class HabitacionDtoRemove : DtoBase
    {

        public int IdHabitacion { get; set; }
        public bool Deleted { get; set; }

    }
}

