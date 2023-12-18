
using Hotel.Application.Core;
using Hotel.Application.Dtos.Categoria;
using Hotel.Application.Exceptions;
using Microsoft.Extensions.Configuration;

namespace Hotel.Application.Extensions
{
    internal static class ValidationCategoriaExtension
    {
        public static ServiceResult IsCategoriaValid(this CategoriaDtoBase categoriaDto, IConfiguration configuration)
        {
            ServiceResult result = new ServiceResult();

            if (string.IsNullOrEmpty(categoriaDto.Nombre))
                throw new CategoriaServiceException(configuration["MensajeValidaciones:categoriaNombreRequerido"]);

            if (categoriaDto.Nombre.Length > 100)
                throw new CategoriaServiceException(configuration["MensajeValidaciones:categoriaNombreLongitud"]);

            // Puedes agregar más validaciones según tus necesidades

            return result;
        }
    }
}
