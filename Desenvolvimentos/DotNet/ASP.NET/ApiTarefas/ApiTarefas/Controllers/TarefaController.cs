using ApiTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private static List<Tarefas> tarefas = new List<Tarefas>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionarTarefas([FromBody]Tarefas tarefa)
        {
            tarefa.Id = id++;
            tarefas.Add(tarefa);
            return CreatedAtAction(nameof(ListarPorId), new {id = tarefa.Id }, tarefa);
        }
        [HttpGet]
        public IEnumerable<Tarefas> ListarTarefas(int skip = 0, int take = 20)
        {
            return tarefas.Skip(skip).Take(take);
        }
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            var tarefa = tarefas.FirstOrDefault(tarefa => tarefa.Id == id);
            if(tarefa == null) return NotFound();
            return Ok(tarefa);
        }
    }
}
