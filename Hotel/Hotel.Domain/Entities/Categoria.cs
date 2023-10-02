using Hotel.Domain.Core;

namespace Hotel.Domain.Entities
{
    public class Categoria : BaseEntity, IEquatable<Categoria?>
    {
        public string? Descripcion { get; set; }
    }
}
