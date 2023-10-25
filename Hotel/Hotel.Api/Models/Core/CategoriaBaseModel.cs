namespace Hotel.Api.Models.Core
{
    public class CategoriaBaseModel : ModelBase
    {
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public bool Deleted { get; set; } = false;
        public CategoriaBaseModel(int cambiarUsuario) : base(cambiarUsuario)
        {
        }
    }
}
