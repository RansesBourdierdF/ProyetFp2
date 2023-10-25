using System.Diagnostics;

namespace Hotel.Api.Models.Core
{
    public class ClienteBaseModel : ModelBase
    {
        public string? NombreCompleto { get; set; }


        public string? Correo { get; set; }

        public int? IdCliente { get; set; }


        public string? Clave { get; set; }

        public bool? Estado { get; set; }
        public ClienteBaseModel(int cambiarUsuario) : base(cambiarUsuario)
        {

        }
    }
}
