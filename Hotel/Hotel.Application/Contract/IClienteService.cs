using Hotel.Application.Core;

namespace Hotel.Application.Contract
{
    public interface IClienteService : IBaseService <ClienteDtoAgregar, ClientDtoActualizar, ClientDtoRemover>

    {
}
    ServiceResult ObtenerPorNombre(string nombre);

}