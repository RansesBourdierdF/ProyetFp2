

namespace Hotel.Application.Core
{
    public interface IBaseService<TDtoAgregar, TDtoActualizar, TDtoRemover>
    {
        ServiceResult ObtenerTodo();
        ServiceResult ObtenerPorId(int Id);
        ServiceResult Guardar(TDtoAgregar dtoAgregar);
        ServiceResult Actualizar (TDtoActualizar dtoActualizar);
        ServiceResult Remover(TDtoRemover dtoRemover);

    }
}
