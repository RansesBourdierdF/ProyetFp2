namespace Hotel.Api.Models.Core
{
    public class RolUsuarioBaseModel : ModelBase
    {
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public bool Delited { get; set; } = false;

    }
}
