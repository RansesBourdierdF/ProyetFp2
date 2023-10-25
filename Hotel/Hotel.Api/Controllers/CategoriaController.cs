using Hotel.Api.Models.Module.Categoria;
using Hotel.Domain.Entities;
using Hotel.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Hotel.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaRepository categoriaRepository;

        public CategoriaController(CategoriaRepository categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
        }

        [HttpGet("GetCategoriaBycategoriaId")]
        public IActionResult GetCategoriaByCategoriaId(int categoriaId)
        {
            var categoria = categoriaRepository.GetCategoriaById(categoriaId);

            if (categoria != null)
            {
                return Ok(categoria);
            }
            else
            {
                // Puedes devolver un código de estado 404 (Not Found) si la Categoria no se encuentra.
                return NotFound();
            }
        }

        [HttpGet("GetCategoria")]
        public IActionResult GetCategoria()
        {
            var categorias = categoriaRepository.GetEntities().Select(dc => new CategoriaGetAllModel()
            {

                Descripcion = dc.Descripcion,
                // Otros campos relacionados con la entidad Categoria
            }).ToList();
            return Ok(categorias);
        }
        [HttpPost("SaveCategoria")]
        public IActionResult Post([FromBody] CategoriaAddModel categoriaAdd)
        {
            Categoria categoria = new Categoria(1)
            {
                CreacionDeUsuario = categoriaAdd.Maddie2,
                ModificarFecha = categoriaAdd.ModificarFecha
            };

            CategoriaRepository categoriaRepository = this.categoriaRepository;
            categoriaRepository.Save(categoria);
            return Ok();
        }

        [HttpPost("UpdateCategoria")]
        public IActionResult Post([FromBody] CategoriaUpdateModel categoriaUpdate)
        {
            

            return Ok();
        }


    }
}