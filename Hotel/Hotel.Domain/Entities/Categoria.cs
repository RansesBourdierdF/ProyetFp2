using Hotel.Domain.Core;
using System;

namespace Hotel.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public Categoria(DateTime? modificacionFecha) : base(modificacionFecha)
        {
        }

        public string? Descripcion {  get; set; }
       


    }
}
