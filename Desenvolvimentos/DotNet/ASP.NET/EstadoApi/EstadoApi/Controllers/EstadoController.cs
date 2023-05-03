using EstadoApi.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstadoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadoController : ControllerBase
    {
        private static List<Estado> estados = new List<Estado>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AdicionarEstado([FromBody]Estado estado)
        {
            estado.Id = id++;
            estados.Add(estado);
            return CreatedAtAction(nameof(ListarEstadosPorId), new {id = estado.Id}, estado);
            
        }
        [HttpGet]
        public IEnumerable<Estado> ListarEstados([FromQuery]int skip = 0, [FromQuery]int take = 10) 
        {
            return estados.Skip(skip).Take(take);
        }
        [HttpGet("{id}")]
        public IActionResult ListarEstadosPorId(int id)
        {
            var estado = estados.FirstOrDefault(estados => estados.Id == id);
            if (estado == null) return NotFound();
            return Ok(estado);
        }
    }
}
