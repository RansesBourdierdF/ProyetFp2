
using Hotel.Application.Core;
using Hotel.Application.Exceptions;

namespace Hotel.Application.Extentions
{
    public static class ValidationClienteExtension
    {
        public static ServiceResult IsClienteValid(this ClienteDtoBase clienteDto, IConfiguration configuration)
        {
            ServiceResult result = new ServiceResult();

            if (string.IsNullOrEmpty(clienteDto.Nombre))
                throw new ClienteServiceException(configuration["MensajeValidaciones:clienteNombreRequerido"]);

            if (clienteDto.Nombre.Length > 100)
                throw new ClienteServiceException(configuration["MensajeValidaciones:clienteNombreLongitud"]);

            // Agregar otras validaciones según sea necesario para el objeto Cliente

            return result;
        }
    }

}

