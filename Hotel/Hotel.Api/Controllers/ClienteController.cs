using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository ClienteRepository;

        public IClienteRepository ClienteRepository1 => ClienteRepository;

        // Constructor que inyecta IClienteRepository
        public ClienteController(IClienteRepository clienteRepository)
        {
            ClienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }
     
        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // Aquí deberías procesar el objeto JSON que llega en el cuerpo de la solicitud.
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // Aquí deberías implementar la lógica para eliminar un cliente por su ID.
        }
    }

    public interface IClienteRepository
    {
    }
}


