using Hotel.Api.Models.Module.Usuario;
using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository usuarioRepository;

        public UsuarioController(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        [HttpGet("GetUsuarioByusuarioId")]
        public IActionResult GetUsuarioByusuarioId(int usuarioId)
        {
            var usuario = this.usuarioRepository.GetUsuarioById(usuarioId);
            return Ok(usuarioId);
        }


        [HttpGet]
        public IActionResult GetUsuario()
        {
            var usuario = this.usuarioRepository.GetEntities().Select(dc => new UsuarioGetAllModel()
            {
                IdUsuario = dc.IdUsuario,
                MarkData = dc.CreationDate,
                NombreCompleto = dc.NombreCompleto,
                Correo = dc.Correo,
                IdRolUsuario = dc.IdRolUsuario,
                Clave = dc.Clave,
                Estado = dc.Estado

            }).ToList();
            return Ok(usuario);
        }

       

        // GET api/<UsuarioController>/5
        [HttpGet("GetUsuario")]
        public IActionResult GetUsuario(int id)
        {
            var usuario = this.usuarioRepository.GetEntities(id);
            return Ok(usuario);
        }

        [HttpPost("SavaUsuario")]
        public IActionResult Post([FromBody] UsuarioAddModel usuarioAdd) 
        {
            Usuario usuario = new Usuario()
            {
                CreationDate = usuarioAdd.MarkData,
                CreationUser = usuarioAdd.User00,
                NombreCompleto = usuarioAdd.NombreCompleto,
                Correo = usuarioAdd.Correo,
                IdRolUsuario = usuarioAdd.IdRolUsuario,
                Clave = usuarioAdd.Clave,
                Estado = usuarioAdd.Estado
               
            };

            this.usuarioRepository.Save(usuario);
            return Ok();
        }

        // POST api/<UsuarioController>
        [HttpPost("UpdateUsuario")]
        public IActionResult Post([FromBody] UsuarioUpdateMoldel usuarioUpdate)
        {
            Usuario usuario = new Usuario()
            {
                IdUsuario = usuarioUpdate.IdUsuario,
                CreationDate = usuarioUpdate.MarkData,
                CreationUser = usuarioUpdate.User00,
                NombreCompleto = usuarioUpdate.NombreCompleto,
                Correo = usuarioUpdate.Correo,
                IdRolUsuario = usuarioUpdate.IdRolUsuario,
                Clave = usuarioUpdate.Clave,
                Estado = usuarioUpdate.Estado
            };

            return Ok();
        }

      
    }
}
