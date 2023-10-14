using Hotel.Domain.Core;
using System;

namespace Hotel.Domain.Entities
{
    public class Categoria : Cliente
    {
        public string? IdCategoria { get; set; }
        public string? Descripcion { get; set; }

        private string? estado;

        public string? GetEstado()
        {
            return estado;
        }

        public void SetEstado(string? value)
        {
            estado = value;
        }
    }
}


