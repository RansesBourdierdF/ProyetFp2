using Hotel.Api.Models.Module.Cliente;  
using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase  
    {
        private readonly ClienteRepository clienteRepository;  

        public ClienteController(ClienteRepository clienteRepository)  
        {
            this.clienteRepository = clienteRepository;
        }

        [HttpGet("GetClienteByClienteId")]
        public IActionResult GetClienteByClienteId(int clienteId)  
        {
            var cliente = clienteRepository.GetClienteById(clienteId);

            if (cliente != null)
            {
                return Ok(cliente);
            }
            else
            {
                // Puedes devolver un código de estado 404 (Not Found) si el Cliente no se encuentra.
                return NotFound();
            }
        }

        [HttpGet("GetCliente")]
        public IActionResult GetCliente()
        {
            var clientes = clienteRepository.GetEntities().Select(dc => new ClienteGetAllModel()
            {
                
                // Otros campos relacionados con la entidad Cliente
            }).ToList();
            return Ok(clientes);
        }

        [HttpPost("SaveCliente")]
        public IActionResult Post([FromBody] ClienteAddModel clienteAdd)
        {
            Cliente cliente = new Cliente(1)
            {
                CreacionDeUsuario = clienteAdd.CreacionDeUsuario, 
                NombreCompleto = clienteAdd.NombreCompleto,
                FechaCreacion = clienteAdd.FechaCreacion,
                Estado = clienteAdd.Estado
            };

            this.clienteRepository.Save(cliente);
            return Ok();
        }

        [HttpPost("UpdateCliente")]
        public IActionResult Post([FromBody] ClienteUpdateModel clienteUpdate)
        {
            Cliente cliente = new Cliente(1)
            {
                CreacionDeUsuario = clienteUpdate.CreacionDeUsuario, 
            };

            return Ok();
        }
    }
}

