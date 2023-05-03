using Microsoft.AspNetCore.Mvc;
using RoupasApi.Models;

namespace RoupasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoupaController : ControllerBase
    {
        private static List<Roupa> roupas = new List<Roupa>();
        private static int id = 0;
        [HttpPost]
        public IActionResult AdicionarRoupa([FromBody]Roupa roupa)
        {
            roupa.Id = id++;
            roupas.Add(roupa);
            return CreatedAtAction(nameof(ListarPorId), new { id = roupa.Id }, roupa);
            
        }
        [HttpGet]
        public IEnumerable<Roupa> ListarRoupa(int skip = 0, int take = 10) 
        {
            return roupas.Skip(skip).Take(take);
        }
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            var roupa = roupas.FirstOrDefault(roupa => roupa.Id == id);
            if (roupa == null) return NotFound();
            return Ok(roupa);
        }
    }
}
