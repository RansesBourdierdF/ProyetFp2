namespace Hotel.Api.Models.Core
{
    public class ModelBase
    {
        public ModelBase(int cambiarUsuario)
        {
            CambiarUsuario = cambiarUsuario;
        }

        public int CambiarUsuario { get; set; }
        public DateTime CambiarFecha { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
