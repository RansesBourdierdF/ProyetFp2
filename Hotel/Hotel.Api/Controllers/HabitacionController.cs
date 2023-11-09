using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    public class HabitacionController : ControllerBase
    {
        private readonly IHabitacionRepository habitacionRepository;

        public HabitacionController(IHabitacionRepository habitacionRepository)
        {
            this.habitacionRepository = habitacionRepository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Habitacion> Get()
        {
           var habitacions = this.habitacionRepository.GetHabitacions();
            return habitacions;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

