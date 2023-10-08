using Hotel.Domain.Core;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Api.Controllers
{
    public class ControllerBase : BaseEntity
    {
        public ControllerBase(int creacionDeUsuario) : base(creacionDeUsuario)
        {
        }
      
        public void Post([FromBody] string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"'{nameof(value)}' cannot be null or empty.", nameof(value));
            }
            // Aquí deberías procesar el objeto JSON que llega en el cuerpo de la solicitud.
        }
    }
}
