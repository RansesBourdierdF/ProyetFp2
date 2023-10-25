
namespace Hotel.Domain.Entities
{
    public class Categoria : Cliente
    {
        public string? IdCategoria { get; set; }
        public new string? Descripcion { get; set; }

        private string? estado;

        public Categoria(int creacionDeUsuario) : base(creacionDeUsuario)
        {
        }

        

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


