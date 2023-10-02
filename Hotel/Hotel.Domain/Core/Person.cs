using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        protected Person(bool eliminar) : base(eliminar)
        {
        }

        public string? Apellido { get; set; }
        public string? PrimerNombre { get; set; }
    }
}
