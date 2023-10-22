using Hotel.Api.Models.Module.RolUsuario;
using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Interfaces;
using Microsoft.AspNetCore.Mvc;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolUsuarioController : ControllerBase
    {
        private readonly IRolRepository rolRepository;

        public RolUsuarioController(IRolRepository rolRepository)
        {
            this.rolRepository = rolRepository;
        }

        [HttpGet("GetRolUsuarioByrolUsuarioId")]
        public IActionResult GetRolUsuarioByrolUsuarioId(int rolUsuarioId)
        {
            var Rolusuario = this.rolRepository.GetRolUsuarioById(rolUsuarioId);
            return Ok(rolUsuarioId);
        }

        [HttpGet]
        public IActionResult GetRolUsuario()
        {

            var rolUsuario = this.rolRepository.GetEntities().Select(cd => new RolUsuarioGetAllModel()
            {
                RolUsuarioId = cd.RolUsuarioId,
                MarkData = cd.CreationDate,
                Descripcion = cd.Descripcion,
                Estado = cd.Estado,
                Delited = cd.Delited


            }).ToList();


            return Ok(rolUsuario);
        }




        // GET api/<RolUsuarioController>/5
        [HttpGet("GetRolUsuario")]
        public IActionResult GetRolUsuario(int id)
        {
            var rolUsuario = this.rolRepository.GetEntity(id);
            return Ok(rolUsuario);
        }

        [HttpPost("SaveRolUsuario")]
        public IActionResult Post([FromBody] RolUsuarioAddModel rolUsuarioAdd)
        {
            RolUsuario rolUsuario = new RolUsuario()
            {
                CreationDate = rolUsuarioAdd.MarkData,
                CreationUser = rolUsuarioAdd.User00,
                Descripcion = rolUsuarioAdd.Descripcion,
                Estado = rolUsuarioAdd.Estado,
                Deleted = rolUsuarioAdd.Delited

            };
            
            this.rolRepository.Save(rolUsuario);

            return Ok();
        }

        // POST api/<RolUsuarioController>
        [HttpPost("UpdateRolUsuario")]
        public IActionResult Put([FromBody] RolUsuarioUpdateModel rolUsuarioUpdate)
        {
            RolUsuario rolUsuario = new RolUsuario()
            {
                RolUsuarioId = rolUsuarioUpdate.RolUsuarioId,
                CreationDate = rolUsuarioUpdate.MarkData,
                CreationUser = rolUsuarioUpdate.User00,
                Descripcion = rolUsuarioUpdate.Descripcion,
                Estado = rolUsuarioUpdate.Estado,
                Deleted = rolUsuarioUpdate.Delited
                
            };
            this.rolRepository.Update(rolUsuario);
            return Ok();
        }

        
    }
}
