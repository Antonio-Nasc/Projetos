using CarrosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarrosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private static List<Carro> carros = new List<Carro>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AdicionarCarro([FromBody] Carro carro)
        {
            carro.Id = id++;
            carros.Add(carro);
            return CreatedAtAction(nameof(ListarPorId), new { id = carro.Id }, carro);
        }
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            var carro = carros.FirstOrDefault(carro => carro.Id == id);
            if(carro == null) return NotFound();
            return Ok(carro);
        }
        [HttpGet]
        public IEnumerable<Carro> ListarCarros(int skip = 0, int take = 10) 
        {

            return carros.Skip(skip).Take(take);
        }
    }
}
