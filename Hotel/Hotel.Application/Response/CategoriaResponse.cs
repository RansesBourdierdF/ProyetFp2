using Hotel.Application.Core;


namespace Hotel.Application.Response
{
    public interface ClienteResponse : ServiceResult
    {
        public int CategoriaId { get; set; }
    }
}
