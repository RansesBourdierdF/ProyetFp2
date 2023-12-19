using Hotel.Domain.Core;
namespace Hotel.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public readonly object Descripcion;


        public Cliente(int creacionDeUsuario) : base(creacionDeUsuario)
        {

        }

        public string? TipoDocumento { get; set; }
        public string? Documento { get; set; }
        public string? NombreCompleto { get; set; }
        public string? correo { get; set; }
        public bool? Estado { get; set; }
    }
}
