namespace Hotel.Web.Models

{
    public class ClienteViewModel 
    {
        public int IdCliente { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public bool Estado { get; set; }
    }
}
