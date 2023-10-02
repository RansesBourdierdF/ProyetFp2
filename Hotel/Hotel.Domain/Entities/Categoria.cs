using Hotel.Domain.Core;
using System;

namespace Hotel.Domain.Entities
{
    public class Categoria : Cliente
    {
        public string? Descripcion { get; set; }
    }
}
