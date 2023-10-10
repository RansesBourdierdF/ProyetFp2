
namespace Hotel.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        protected Person(int creacionDeUsuario) : base(creacionDeUsuario)
        {
        }

        public string? Apellido { get; set; }
        public string? PrimerNombre { get; set; }
    }
}
