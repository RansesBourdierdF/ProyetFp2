using Hotel.Domain.Core;
using System;

namespace Hotel.Domain.Entities
{
    public class Categoria : Cliente
    {
        public string? IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        
    }
}


