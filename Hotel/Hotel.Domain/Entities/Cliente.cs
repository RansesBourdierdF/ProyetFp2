using Hotel.Domain.Core;
using System;


namespace Hotel.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public int Idcliente {  get; set; }
        public string? TipoDocumento { get; set; }
        public string? Documento { get; set; }
        public string? NombreCompleto { get; set; }
        public string? correo {  get; set; }
        public bool? Estado {  get; set; }
        public DateTime? FechaCreacion { get; set;}


    }
}
